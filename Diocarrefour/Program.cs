using System;
using Telegram.Bot;

namespace Diocarrefour
{
    class Program
    {

        private static readonly TelegramBotClient botClient = new TelegramBotClient("1397538386:AAHycJJOdol_iZBqiUW5jms8rvmqO7bjA4s");

        static void Main(string[] args)

        {
            botClient.OnMessage += Bot_OnMessage;
            botClient.OnMessageEdited += Bot_OnMessage;


            botClient.StartReceiving();
            Console.ReadLine();
            botClient.StopReceiving();
        }

        private static void Bot_OnMessageEdited(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {

            if (e.Message.Text != null)

            {
                if (e.Message.Text == "/1: PARA 2ª VIA DA FATURA")
                
                    botClient.SendTextMessageAsync(e.Message.Chat.Id, "Informe seu CPF");
                
                else if (e.Message.Text == "12312312312")
                {
                    botClient.SendTextMessageAsync(e.Message.Chat.Id, " Gerando... ... ...");
                    botClient.SendTextMessageAsync(e.Message.Chat.Id, " Segue Código de Barra: xxxxxxxxxxxxxx \nVENCIMENTO 10/08/2020 ");
                }

                else if (e.Message.Text == "/2: PARA CONSULTAR LIMITE DISPONÍVEL")
                {
                    botClient.SendTextMessageAsync(e.Message.Chat.Id, " Um Momento...");
                    botClient.SendTextMessageAsync(e.Message.Chat.Id, " Seu Limite é de R$ 1.000,00");
                }

                else if (e.Message.Text == "/3: PARA BLOQUEIO POR PERDA E ROUBO")
                {
                    botClient.SendTextMessageAsync(e.Message.Chat.Id, "Um Momento... ...");
                    botClient.SendTextMessageAsync(e.Message.Chat.Id, "CARTÃO BLOQUEADO!\nPara Solicitar Um Novo Cartão Acesse: https://aquisicao.carrefoursolucoes.com.br/ Ou Ligue Para: 0800 123 123" + e.Message.Chat.Username);
                    
                }

                else if (e.Message.Text == "/4: PARA BLOQUEIO TEMPORÁRIO")
                {
                    botClient.SendTextMessageAsync(e.Message.Chat.Id, "Um Momento...");
                    botClient.SendTextMessageAsync(e.Message.Chat.Id, "CARTÃO BLOQUEADO!\nPara Solicitar O Desbloqueio Acessar O APP: \nDisponível para IOS https://apps.apple.com/br/app/cart%C3%A3o-carrefour/id1156553924 \nE Para ANDROIDE https://play.google.com/store/apps/details?id=br.com.carrefour.cartaocarrefour&hl=pt_BR");

                }

                else if (e.Message.Text == "/5: TIRE SUAS DÚVIDAS")
                {
                    botClient.SendTextMessageAsync(e.Message.Chat.Id, "Para Saber Mais Sobre Seu Cartão Acesse:\n https://www.carrefoursolucoes.com.br/seguros/duvidas-frequentes" + e.Message.Chat.Username);
                }


                else
                {

                    botClient.SendTextMessageAsync(e.Message.Chat.Id, $"Olá {e.Message.From.FirstName}! Bem Vindo :)");
                    botClient.SendTextMessageAsync(e.Message.Chat.Id, "Vamos Válidar Seu CPF ;)");
                    botClient.SendTextMessageAsync(e.Message.Chat.Id, @"COMO PODEMOS TE AJUDAR? 


                      /1: PARA 2ª VIA DA FATURA
                      /2: PARA CONSULTAR LIMITE DISPONÍVEL
                      /3: PARA BLOQUEIO POR PERDA E ROUBO
                      /4: PARA BLOQUEIO TEMPORÁRIO
                      /5: TIRE SUAS DÚVIDAS
                  ");


                }


            }
            Console.WriteLine(e.Message.Text);
        }
    }
}
