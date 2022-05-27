﻿CriarDiretorio();

static void CriarDiretorio()
{
    var path = Path.Combine(Environment.CurrentDirectory, "globo");

    if (!Directory.Exists(path))
    {
        var dirGLobo = Directory.CreateDirectory(path);

        var dirAmericaNorte = dirGLobo.CreateSubdirectory("América do Norte");
        var dirAmericaSul = dirGLobo.CreateSubdirectory("América do Sul");
        var dirAmericaCentro = dirGLobo.CreateSubdirectory("América Central");

        dirAmericaCentro.CreateSubdirectory("Costa Rica");

        dirAmericaNorte.CreateSubdirectory("USA");

        dirAmericaSul.CreateSubdirectory("Brasil");
    }


}

