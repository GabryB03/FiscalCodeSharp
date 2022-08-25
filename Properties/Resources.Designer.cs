﻿using System;


/// <summary>
///   Classe di risorse fortemente tipizzata per la ricerca di stringhe localizzate e così via.
/// </summary>
// Questa classe è stata generata automaticamente dalla classe StronglyTypedResourceBuilder.
// tramite uno strumento quale ResGen o Visual Studio.
// Per aggiungere o rimuovere un membro, modificare il file con estensione ResX ed eseguire nuovamente ResGen
// con l'opzione /str oppure ricompilare il progetto VS.
[global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
internal class Resources
{

    private static global::System.Resources.ResourceManager resourceMan;

    private static global::System.Globalization.CultureInfo resourceCulture;

    [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
    internal Resources()
    {
    }

    /// <summary>
    ///   Restituisce l'istanza di ResourceManager nella cache utilizzata da questa classe.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    internal static global::System.Resources.ResourceManager ResourceManager
    {
        get
        {
            if (object.ReferenceEquals(resourceMan, null))
            {
                global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FiscalCodeSharp.Properties.Resources", typeof(Resources).Assembly);
                resourceMan = temp;
            }
            return resourceMan;
        }
    }

    /// <summary>
    ///   Esegue l'override della proprietà CurrentUICulture del thread corrente per tutte le
    ///   ricerche di risorse eseguite utilizzando questa classe di risorse fortemente tipizzata.
    /// </summary>
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
    internal static global::System.Globalization.CultureInfo Culture
    {
        get
        {
            return resourceCulture;
        }
        set
        {
            resourceCulture = value;
        }
    }

    /// <summary>
    ///   Cerca una stringa localizzata simile a Comune;Codice
    ///ABANO TERME;A001
    ///ABBADIA CERRETO;A004
    ///ABBADIA LARIANA;A005
    ///ABBADIA SAN SALVATORE;A006
    ///ABBASANTA;A007
    ///ABBATEGGIO;A008
    ///ABBIATEGRASSO;A010
    ///ABETONE;A012
    ///ABRIOLA;A013
    ///ACATE;A014
    ///ACCADIA;A015
    ///ACCEGLIO;A016
    ///ACCETTURA;A017
    ///ACCIANO;A018
    ///ACCUMOLI;A019
    ///ACERENZA;A020
    ///ACERNO;A023
    ///ACERRA;A024
    ///ACI BONACCORSI;A025
    ///ACI CASTELLO;A026
    ///ACI CATENA;A027
    ///ACI SANT&apos;ANTONIO;A029
    ///ACIREALE;A028
    ///ACQUACANINA;A031
    ///ACQUAFONDATA;A032
    ///ACQUAFORMOSA;A033
    ///ACQUAFREDDA;A034
    ///ACQUALAGNA;A035
    ///ACQUANEGRA CR [stringa troncata]&quot;;.
    /// </summary>
    internal static string comuni
    {
        get
        {
            return ResourceManager.GetString("comuni", resourceCulture);
        }
    }
}