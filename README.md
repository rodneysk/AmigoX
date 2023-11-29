# AmigoX

Programinha feito em C# para sorteio de amigo x (amigo secreto).

Funcionamento:
- Basta informar o nome dos participantes e executar o programa;
- Por ora é necessário ter o Visual Studio ou alguma outra IDE instalada para poder executá-lo;

Detalhamento do projeto:
- Nele eu informo uma lista com todos os participantes e crio um dicionário para armazenar o resultado do sorteio;
- Gero um arquivo .txt com o resultado de quem tirou quem;
- Tenho uma função responsável por realizar o sorteio, levando em consideração que nenhum participante pode tirar ele mesmo e ninguém pode ser sorteado mais do que uma vez;
- O arquivo gerado é salvo no diretório do próprio projeto \bin\debug\net6.0\ResultadoAmigoSecreto.txt;

Upgrade:
- Na próxima versão vou aplicar algo mais visual como num form ou web;
- Tentarei utilizar a API do WhatsApp Business para o envio do sorteio ser direto para os participantes;
