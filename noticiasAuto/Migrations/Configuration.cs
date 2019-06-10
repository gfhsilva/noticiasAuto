namespace noticiasAuto.Migrations
{
    using noticiasAuto.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<noticiasAuto.Models.NoticiasDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(noticiasAuto.Models.NoticiasDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.



            var equipas = new List<Equipas> {
                new Equipas { IdEquipa = 1, Nome = "Fiat", DataFundacao = new DateTime(1989, 06, 1), Logo = "fiat.jfif", Fundador = "Giovanni Agnelli", Nacionalidade = "Turim, It�lia", },
                new Equipas { IdEquipa = 2, Nome = "Audi", DataFundacao = new DateTime(1909, 06, 16), Logo = "audi.jpg", Fundador = "August Horch", Nacionalidade = "Ingolstadt, Alemanha" },
                new Equipas { IdEquipa = 3, Nome = "Ford", DataFundacao = new DateTime(1903, 06, 16), Logo = "ford.jpg", Fundador = "Henry Ford", Nacionalidade = "Dearborn, Michigan, Estados Unidos" },
                new Equipas { IdEquipa = 4, Nome = "Ferrari", DataFundacao = new DateTime(1939, 09, 13), Logo = "ferrari.jpg", Fundador = "Enzo Ferrari", Nacionalidade = "Maranello, It�lia" },
                new Equipas { IdEquipa = 5, Nome = "Citro�n", DataFundacao = new DateTime(1919, 01, 1), Logo = "Citro�n.jpg", Fundador = "Andr� Citro�n", Nacionalidade = "Paris, Fran�a" },
                new Equipas { IdEquipa = 6, Nome = "Mitsubishi", DataFundacao = new DateTime(1870, 01, 1), Logo = "Mitsubishi.jpg", Fundador = "Yataro Iwasaki", Nacionalidade = "T�quio, Jap�o" },
                new Equipas { IdEquipa = 7, Nome = "Subaru", DataFundacao = new DateTime(1953, 05, 7), Logo = "Subaru.jpg", Fundador = "Kenji Kita Chikuhei Nakajima", Nacionalidade = "Ota,Gunma, Jap�o" },
                new Equipas { IdEquipa = 8, Nome = "Mercedes", DataFundacao = new DateTime(1926, 01, 1), Logo = "mercedes.jpg", Fundador = "Karl Benz", Nacionalidade = "Stuttgart, Alemanha" },


            };

            equipas.ForEach(ee => context.Equipas.AddOrUpdate(e => e.Nome, ee));
            context.SaveChanges();


            var pilotos = new List<Pilotos> {
                new Pilotos { IdPiloto = 1, Nome = "Marku Allen", DataNascimento = new DateTime(1950, 02, 15), Categoria = "Rally", Nacionalidade = "Finlandesa", Fotografia = "Marku.jpg", EquipaFK = 1 },
                new Pilotos { IdPiloto = 2, Nome = "Walter R�hrl", DataNascimento = new DateTime(1947, 03, 07), Categoria = "Rally", Nacionalidade = "Alem�", Fotografia = "walter.jpg", EquipaFK = 2 },
                new Pilotos { IdPiloto = 3, Nome = "Stig Blomqvist", DataNascimento = new DateTime(1946, 07, 29), Categoria = "Rally", Nacionalidade = "Sueca", Fotografia = "stig.jpg", EquipaFK = 3 },
                new Pilotos { IdPiloto = 4, Nome = "Michael Schumacher", DataNascimento = new DateTime(1969, 01, 3), Categoria = "F1", Nacionalidade = "Alem�", Fotografia = "Schumacher.jpg", EquipaFK = 4 },
                new Pilotos { IdPiloto = 5, Nome = "Sebastan Loeb", DataNascimento = new DateTime(1974, 02, 16), Categoria = "Rally", Nacionalidade = "Francesa", Fotografia = "Loeb.jpg", EquipaFK = 5 },
                new Pilotos { IdPiloto = 6, Nome = "Armindo Ara�jo", DataNascimento = new DateTime(1974, 02, 26), Categoria = "Rally", Nacionalidade = "Portuguesa", Fotografia = "Araujo.jpg", EquipaFK = 6 },
                new Pilotos { IdPiloto = 7, Nome = "Richard Burns", DataNascimento = new DateTime(1971, 01, 17), Categoria = "Rally", Nacionalidade = " Inglesa", Fotografia = "Burns.jpg", EquipaFK = 7 },
                new Pilotos { IdPiloto = 7, Nome = "Lewis Hamilton", DataNascimento = new DateTime(1985, 01, 07), Categoria = "F1", Nacionalidade = "Inglesa", Fotografia = "Hamilton.jpg", EquipaFK = 8 },
                new Pilotos { IdPiloto = 7, Nome = "Valtteri Bottas", DataNascimento = new DateTime(1989, 08, 28), Categoria = "F1", Nacionalidade = "Finlandesa", Fotografia = "ValtteriBottas.jpg", EquipaFK = 8 },
                new Pilotos { IdPiloto = 7, Nome = "Sebastian Vettel", DataNascimento = new DateTime(1987, 07, 03), Categoria = "F1", Nacionalidade = "Alem�", Fotografia = "SebastianVettel.jpg", EquipaFK = 4 },
            };

            pilotos.ForEach(pp => context.Pilotos.AddOrUpdate(p => p.Nome, pp));
            context.SaveChanges();



            var utilizadores = new List<utilizadores> {
                new utilizadores { IdUser = 1, Nome = "Paulo Sousa", Email = "paulo@sp.pt" },
                new utilizadores { IdUser = 2, Nome = "Paulo Silva", Email = "pauloS@sp.pt" },
                new utilizadores { IdUser = 3, Nome = "Miguel Maria", Email = "mm@sp.pt" },
                new utilizadores { IdUser = 4, Nome = "Jo�o Sousa", Email = "js@sp.pt" },
                new utilizadores { IdUser = 5, Nome = "Sara Cardoso", Email = "sc@sp.pt" },
                new utilizadores { IdUser = 6, Nome = "Guilherme Silva", Email = "gs@sp.pt" },
                new utilizadores { IdUser = 7, Nome = "Ana Costa", Email = "Js@sp.pt" },
                new utilizadores { IdUser = 8, Nome = "Diego Amorim", Email = "Js@sp.pt" },
                new utilizadores { IdUser = 9, Nome = "Lurdes Costa", Email = "Js@sp.pt" },
                new utilizadores { IdUser = 10, Nome = "Fernando Viseu", Email = "Js@sp.pt" },
                new utilizadores { IdUser = 11, Nome = "Fernando Costa", Email = "fCosta@sp.pt" },
                new utilizadores { IdUser = 12, Nome = "Pedro Silva", Email = "PSSSS@sp.pt" },

            };

            utilizadores.ForEach(uu => context.Utilizadores.AddOrUpdate(u => u.Nome, uu));
            context.SaveChanges();



            var noticias = new List<Noticias> {
                new Noticias { IdNoticia = 1, Fotografia = "araujoNotica.jpg", Titulo = "CPR, RALI DE MORT�GUA, ARMINDO ARA�JO: �BOM RESULTADO, MAS TEMOS DE TRABALHAR", Conteudo = "Em entrevista ao Autosport, Armindo Ara�jo felicitou os vencedores do rali de Mort�gua, tamb�m mostrando-se satisfeito com os pontos amealhados do segundo lugar. Ara�jo tamb�m fala na extrema competitividade do Campeonato de Portugal de Ralis. Oi�a aqui.", UserFK= 1 },
                new Noticias { IdNoticia = 2, Fotografia = "burnsNoticia.jpg", Titulo = "LEMBRA-SE DE: RICHARD BURNS, O PRIMEIRO INGL�S A VENCER O MUNDIAL DE RALIS� ", Conteudo = "Foi no dia de hoje, h� precisamente 17 anos, em 2001, que Richard Burns e Robert Reid asseguraram a conquista do seu t�tulo Mundial de Ralis. O terceiro lugar no Rali da Gr�-Bretanha foi o suficiente, depois de Colin McRae ter abandonado a prova. Foi o primeiro, e �nico at� hoje, piloto ingl�s, que n�o brit�nico (esse foi o escoc�s Colin McRae em 1995) a ser Campe�o do Mundo de Ralis.Nesse dia, habitualmente bastante reservado em p�blico, Richard Burns colocou de parte a sua tradicional �fleuma� e deu largas ao seu contentamento no final do Rali da Gr�-Bretanha. � que, ao cabo e ao resto, o piloto da Subaru tinha acabado de se sagrar Campe�o do Mundo de Ralis, isto depois de ter sido vice-campe�o em 1999 e 2000.r isso, as primeiras palavras que proferiu na altura refletiam bem o estado de esp�rito do ingl�s: �Sinto-me fant�stico! Havia uma press�o enorme antes do rali ir para a estrada, press�o vinda de todas as partes, e chegar ao fim da prova com este resultado � absolutamente incr�vel. Sinto pena em n�o garantir o t�tulo com uma vit�ria no �meu� rali mas, ap�s as desist�ncias dos meus advers�rios, a estrat�gia teve que ser alterada para n�o corrermos riscos desnecess�rios. Mais que chegar � vit�ria, tinha a possibilidade de ser Campe�o do Mundo! A conquista do t�tulo representa o trabalho e empenho de toda a equipa, que est� de parab�ns.�Makinen e McRae desistiram cedo: Adeus t�tulo� e recordeAo contr�rio do que tinha acontecido nos cinco anos anteriores, o t�tulo mundial n�o foi para a Finl�ndia! � partida para este Rali da Gr�-Bretanha de 2001, Tommi Makinen e Colin McRae � tal como Carlos Sainz � tinham dois objectivos, mesmo se um deles n�o passava de secund�rio: sagrar-se Campe�o do Mundo e, de permeio, estabelecer o novo recorde de vit�rias em provas do �Mundial� de Ralis. E melhor cen�rio n�o poderia existir, pois o Rali da Gr�-Bretanha era o palco onde quatro pilotos tinham pretens�es ao t�tulo, dos quais tr�s poderiam ascender � t�o procurada 24� vit�ria.Sabia-se que Richard Burns e McRae eram apontados como favoritos para vencer em �casa�, mas foi do lado de Makinen que veio a primeira �surpresa�: abandonou na segunda classificativa, ap�s ter batido numa pedra, que danificou a suspens�o do Lancer Evolution WRC e arrancou uma roda ao carro japon�s. Mas ainda a not�cia do abandono do finland�s estava a ser digerida e o �Mundial� perdia um segundo pretendente ao �ceptro�, pois Colin McRae saiu de estrada na classificativa seguinte: �Tudo aconteceu numa curva para a direita, muito r�pida, onde McRae perdeu o controlo do Focus WRC e capotou por quatro vezes, antes de se imobilizar. Quer o piloto como o navegador nada sofreram�, explicou um desalentado Malcolm Wilson.", UserFK = 1 },
                new Noticias { IdNoticia = 3, Fotografia = "SCHUMACHERNoticia.jpg", Titulo = "F1: MICHAEL SCHUMACHER TER� DOCUMENT�RIO", Conteudo = "Um document�rio oficial sobre Michael Schumacher, totalmente apoiado pela fam�lia, ser� lan�ado ainda este ano.Intitulado de �Schumacher�, o filme � apoiado por uma grande produtora e apresenta entrevistas com o pai de Michael, Rolf, a sua esposa Corinna, os filhos Gina e Mick e outras pessoas essenciais na carreira do alem�o. Tamb�m conta com imagens de arquivo da carreia de Schumacher.A Rocket Science, sediada em Londres, � a produtora executiva e a respons�vel pelas vendas internacionais, sendo que pretende come�ar a comercializar o filme no festival de cinema de Cannes.", UserFK= 1 },
                new Noticias { IdNoticia = 4, Fotografia = "MarkuNoticia.jpg", Titulo = "Markku Alen. O penta campe�o do Rali de Portugal em Castelo Rodrigo", Conteudo = "Markku Alen vai estar em Figueira de Castelo Rodrigo para proporcionar um grande espect�culo na prova m�tica nacional que este ano assinala duas d�cadas.", UserFK = 1 },
                new Noticias { IdNoticia = 5, Fotografia = "StigBlomqvistNoticia.jpg", Titulo = "Recorde quando Blomqvist voou a 189 km/h na Argentina", Conteudo = "Come�a a 25 de abril mais uma edi��o do Rali da Argentina, e a organiza��o do Mundial recordou um dos seus momentos mais impressionantes. Falamos de quando Stig Blomqvist e o Audi Quattro terminaram a primeira especial com uma velocidade m�dia (!) de 189,53 km/hH� feitos que ficam na hist�ria de competi��o e a forma como Stig Blomqvist voou sobre a terra batida da Argentina em 1983 � um deles. O site do WRC recordou agora esta hist�ria fant�stica, que aqui lhe trazemos. O protagonista � Stig Blomqvist que, por correr o Campeonato Brit�nico em simult�neo, chegou � prova do WRC em cima do arranque, sem oportunidade de fazer o reconhecimento com o Audi Quattro. A solu��o foi usar as notas do navegador do seu colega de equipa, Hannu Mikkola.Tenha sido das notas, do jet lag ou por qualquer outro motivo, aquilo que Blomqvist fez � not�vel. Foram 81km cumpridos de forma alucinante, em apenas 25 minutos e 48 segundos. Daqui resultou uma incr�vel m�dia de 189,53 km/h, ainda mais impressionante se considerarmos que a afina��o do seu Audi Quattro colocava a velocidade m�xima nos 210 km/h. Ou seja, o ponteiro do veloc�metro deve ter estado a maior parte do tempo bem colado ao limite e o das rota��es pouco tempo passou fora do redline!Al�m de recordar este feito, o WRC recordou tamb�m que a m�dia de velocidade mais alta para todo um rali data de 2016. O autor foi Kris Meeke, com o seu Citr�en C3 WRC a terminar a corrida na Finl�ndia com um balan�o de 126,62 km/h. Mais uma prova que o piloto brit�nico � bastante r�pido. O problema mesmo � manter-se dentro dos limites da estrada�", UserFK= 1 },
                new Noticias { IdNoticia = 5, Fotografia = "SebastanNoticia.jpg", Titulo = "Tanak vence no Chile com Ogier em segundo e Loeb em terceiro", Conteudo = "Ott Tanak conquistou a vit�ria no Rally do Chile, enquanto Sebastien Ogier ficou em segundo lugar, fora do alcance de Sebastien Loeb.Tanak gostou do novo evento, ao contr�rio de muitos dos competidores que tiveram dificuldade com ader�ncia, para enfrentar os est�gios desconhecidos, conquistando sua segunda vit�ria em 2019.Tanak est� em segundo lugar no campeonato, 10 pontos atr�s do l�der Ogier.Havia 5,1 segundos entre Ogier e Loeb para o domingo, que o piloto da Hyundai conseguiu reduzir para 1,1 segundo no primeiro est�gio da corrida.No entanto, a diferen�a aumentou � medida que a manh� avan�ava e o segundo melhor tempo de Ogier, apesar do incomum incidente de seu extintor de inc�ndio, que explodiu no carro, permitiu que ele mantivesse a diferen�a por mais de sete segundos.O Chile marca o primeiro p�dio de Loeb para a equipe Hyundai.A dupla da M-Sport de Elfyn Evans e Teemu Suninen terminou o rally em quarto e quinto, um sucesso para a equipe, considerando as lutas que os pilotos enfrentaram.Esapekka Lappi terminou em sexto, com seu C3 tendo dificuldade de baixa ader�ncia de manh�.Andreas Mikkelsen estava com um certo otimismo excessivo, mas terminou o final de semana em s�timo.Kris Meeke subiu de volta para a oitava posi��o ap�s colidir com um toco de �rvore no s�bado, ao passar pelo vencedor da WRC2 Pro, Kalle Rovanpera.Mads Ostberg completou o top 10, quase 3 minutos � frente de Jari-Matti Latvala, que reiniciou o rally no domingo, depois de uma falha no eixo de tra��o na noite de s�bado.Latvala estava em terceiro lugar antes do incidente, mas teve o consolo de conquistar tr�s pontos no campeonato.", UserFK= 1 }

            };

            noticias.ForEach(nn => context.Noticias.AddOrUpdate(n => n.Titulo, nn));
            context.SaveChanges();

               
            var comentarios = new List<Comentarios> {
                new Comentarios { IdComentario = 1, Conteudo = "Teste-------Teste------teste-----", NoticiaFK = 2, UserFK = 1 },
                new Comentarios { IdComentario = 1, Conteudo = "Teste-------Teste------teste-----", NoticiaFK = 2, UserFK = 1 },
                new Comentarios { IdComentario = 2, Conteudo = "Teste-------Teste------teste-----", NoticiaFK = 2, UserFK = 1 },
                new Comentarios { IdComentario = 3, Conteudo = "Teste-------Teste------teste-----", NoticiaFK = 2, UserFK = 2 },
                new Comentarios { IdComentario = 4, Conteudo = "Teste-------Teste------teste-----", NoticiaFK = 2, UserFK = 1 },
                new Comentarios { IdComentario = 5, Conteudo = "Teste-------Teste------teste-----", NoticiaFK = 2, UserFK = 6 },
                new Comentarios { IdComentario = 6, Conteudo = "Teste-------Teste------teste-----", NoticiaFK = 3, UserFK = 1 },
                new Comentarios { IdComentario = 7, Conteudo = "Teste-------Teste------teste-----", NoticiaFK = 5, UserFK = 1 },
                new Comentarios { IdComentario = 8, Conteudo = "Teste-------Teste------teste-----", NoticiaFK = 3, UserFK = 8 },
                new Comentarios { IdComentario = 9, Conteudo = "Teste-------Teste------teste-----", NoticiaFK = 2, UserFK = 1 },
                new Comentarios { IdComentario = 10, Conteudo = "Teste-------Teste------teste-----", NoticiaFK = 2, UserFK = 1 },
                new Comentarios { IdComentario = 11, Conteudo = "Teste-------Teste------teste-----", NoticiaFK = 2, UserFK = 9 },
               
            };

            comentarios.ForEach(cc => context.Comentarios.AddOrUpdate(c => c.Utilizador, cc));
            context.SaveChanges();


        }
    }
}
