namespace Máquina_Café
{
    public partial class Form1 : Form
    {
        public Form1() // Construtor que inicializa o formulário
        {
            InitializeComponent(); //que configura o formulário, incluindo a inicialização dos controles visuais (como botões, rótulos, caixas de texto, etc.)
        }
        //declara as variaveis e matrizes com relacao ao troco que sera utilizado e retirado da máquina de café
        float valor = 0; // Valor inserido pelo usuário
        float totalPagar = 0;  // Total acumulado para pagamento
        float troco = 0; // Valor do troco a ser devolvido ao cliente
        float[,] matrizMoedas = {{2.00f,1.00f,0.50f,0.20f,0.10f,0.05f}, // Denominações // Matriz que representa as denominações das moedas, a quantidade necessária para o troco, e a quantidade total disponível
                                {0,0,0,0,0,0}, // Quantidade para o troco
                                {100,100,100,100,100,100 } }; // Estoque de moedas

        // Método chamado quando o formulário é carregado
        private void Form1_Load(object sender, EventArgs e) // Configura o texto e a visibilidade dos controles para o estado inicial
        {
            txt_EscolhaCafé.Text = "Por favor, escolha seu café aqui!"; 
            txt_EscolhaCafé.Visible = true; // Torna visível a mensagem de escolha de café
            txt_Mensagem.Visible = false; // Esconde a mensagem de pagamento
            lbl_Pedido.Visible = false; // Esconde os detalhes do pedido
            lbl_Pedido.Text = "Dedalhes do Pedido: \n"; // Texto inicial do rótulo do pedido
            lbl_MostrarTroco.Visible = false; // Esconde a mensagem do troco
        }

        //O método é chamado quando o botão de café é clicado. 
        private void btn_cafe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seu café custa 0.25€!\r Por favor, introduza seu dinheiro na máquina!"); // Mensagem ao cliente sobre o custo do café
            totalPagar += 0.25f; // Atualiza o total a pagar
            lbl_Pedido.Text += "\n 1 café = 0,25€"; // Adiciona ao rótulo de detalhes do pedido
            lbl_Pedido.Visible = true; // Torna visível os detalhes do pedido
        }

        private void btn_cappuccino_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seu cappuccino custa 0.30€! \r Por favor, introduza seu dinheiro na máquina!"); // Mensagem ao cliente sobre o custo do cappuccino
            totalPagar += 0.30f; // Atualiza o total a pagar
            lbl_Pedido.Text += "\n 1 cappuccino = 0,30€"; // Atualiza os detalhes do pedido
            lbl_Pedido.Visible = true; // Torna visível os detalhes do pedido
        }

        private void btn_chocolate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seu chocolate custa 0.35€! \r Por favor, introduza seu dinheiro na máquina!"); // Mensagem ao cliente sobre o custo do chocolate quente
            totalPagar += 0.35f; // Atualiza o total a pagar
            lbl_Pedido.Text += "\n 1 chocalate = 0,35€"; // Atualiza os detalhes do pedido
            lbl_Pedido.Visible = true;  // Torna visível os detalhes do pedido
        }

        private void btn_cha_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seu chá custa 0.20€! \r Por favor, introduza seu dinheiro na máquina!"); // Mensagem ao cliente sobre o custo do chá
            totalPagar += 0.20f; // Atualiza o total a pagar
            lbl_Pedido.Text += "\n 1 chá = 0,20€"; // Atualiza os detalhes do pedido
            lbl_Pedido.Visible = true; // Torna visível os detalhes do pedido
        }

        //O método é chamado quando o botão de pagamento é clicado e faz as devidas verificações e ações.
        private void btn_Pagar_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txt_EscreverValor.Text, out float valor) && valor >= totalPagar) // Verifica se o valor inserido é válido e suficiente para pagar
            {
                troco = (float)Math.Round(valor - totalPagar, 2); // Calcula o troco e arredonda para duas casas decimais
                txt_Mensagem.Visible = true; // Exibe a mensagem com o total a pagar e o troco
                txt_Mensagem.Text = "O valor total do seu pedido é: " + totalPagar.ToString("F2") + " €" + ". O seu troco é: " + troco.ToString("F2") + " €." + " Obrigada por escolher a Máquina de Café!";
                txt_Mensagem.Font = new Font("Cascadia Mode", 10, FontStyle.Bold); // Configura a fonte e o tamanho do texto
                lbl_MostrarTroco.Visible = true; // Exibe a mensagem sobre o troco e calcula as moedas necessárias
                mostrarTroco(troco, matrizMoedas); // Calcula e exibe as moedas para o troco
                tirarMoedas(matrizMoedas); // Atualiza o estoque de moedas
                mostrarMoedeiro(matrizMoedas); // Exibe a quantidade de moedas restantes
            }
            else
            {
                MessageBox.Show("Atenção, introduza um valor válido!"); // Se o valor inserido não é válido, exibe uma mensagem de erro
                txt_EscreverValor.ResetText(); // Limpa o valor inserido
                txt_EscreverValor.Focus(); // Dá foco na caixa de texto para nova entrada
            }
        }

        //O método calcula quantas moedas de cada denominação são necessárias para dar o troco e exibe isso em lbl_MostrarTroco.
        //Ele usa uma abordagem de divisão para calcular quantas moedas de cada denominação são necessárias, atualiza a matriz de moedas
        //e arredonda o troco para garantir precisão.
        private void mostrarTroco(float troco, float[,] moedasVal)
        {
            int resultado; // Quantidade de moedas necessárias para cada denominação
            for (int i = 0; i < 6; i++)  // Para cada denominação, calcula quantas moedas são necessárias para dar o troco
            {
                resultado = (int)(troco / moedasVal[0, i]); // Quantas moedas desta denominação são necessárias
                if (resultado >= 1) // Se pelo menos uma moeda é necessária
                {
                    moedasVal[1, i] = resultado; // Atualiza a matriz com a quantidade necessária
                    troco = (float)Math.Round((troco % moedasVal[0, i]), 2); // Atualiza o troco restante após dar essas moedas
                }
            }
            for (int j = 0; j < 6; j++) // Exibe a quantidade de moedas necessárias para o troco
            {
                if (moedasVal[1, j] > 0) // Se a quantidade é maior que zero
                {
                    lbl_MostrarTroco.Text += $" \n Moedas de {moedasVal[0, j]:0.00} € :  {moedasVal[1, j]}"; // Adiciona ao rótulo do troco
                }
            }

        }
        // O método reduz a quantidade de moedas disponíveis, subtraindo as moedas usadas para dar o troco.
        private void tirarMoedas(float[,] moedas) 
        {
            for(int i = 0; i < 6; i++) // Subtrai a quantidade de moedas usadas para o troco do estoque total
            {                
                if (moedas[1, i] > 0) // Se foram usadas moedas desta denominação
                {
                    moedas[2, i] = moedas[2, i] - moedas[1, i]; // Atualiza o estoque total
                }
            }
        }

        //O método exibe a quantidade de moedas restantes após a operação de pagamento. Ele percorre a matriz de moedas e
        //adiciona a informação ao rótulo lbl_Moedeiro.
        private void mostrarMoedeiro(float[,] moedas)
        {
            lbl_Moedeiro.Text = "As moedas restantes são: "; // Inicializa com uma mensagem padrão

            for (int i = 0;i < 6; i++) // Adiciona ao rótulo a quantidade de moedas restantes para cada denominação
            {
                lbl_Moedeiro.Text += "\n" + moedas[0, i] + " €: " + moedas[2, i] + " unidades";
            }
        }

        //O método é chamado quando o botão de cancelamento é clicado, encerrando a aplicação.
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Encerra a aplicação
        }
    }
}
