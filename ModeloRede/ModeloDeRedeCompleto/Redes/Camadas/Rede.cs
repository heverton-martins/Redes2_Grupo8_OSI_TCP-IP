﻿using ModeloDeRede.Redes.Enderecos;

namespace ModeloDeRede.Redes.Camadas
{
    /// <summary>
    /// Camada 3: Rede
    /// </summary>
    public abstract class Rede : Camada
    {
        protected Endereco enderecoIp;

        public Rede(Endereco enderecoIp) => this.enderecoIp = enderecoIp;

        public abstract void ReceberMensagem(Mensagem mensagem);

        public abstract void EnviarMensagem(Endereco ipDestino, Mensagem mensagem);
    }
}