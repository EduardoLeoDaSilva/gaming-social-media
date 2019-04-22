﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace InstaProj.Models.Entidades
{
    [DataContract]
    public class Postagem
    {

        public Postagem()
        {

        }

        public Postagem(Usuario usuario, byte[] imagem, string texto)
        {
            Usuario = usuario;
            Imagem = imagem;
            Texto = texto;
        }

        [DataMember]
        public int PostagemId  { get; private set; }
        [DataMember]
        public Usuario Usuario { get; private set; }
        //[DataMember]
        //public Feed Feed { get; private set; }
        [DataMember]
        public byte[] Imagem { get; private set; }
        [DataMember]
        public string Texto { get; private set; }

    }
}
