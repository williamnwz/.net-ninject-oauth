using Estudo1.CrossCutting.Security;
using Estudo1.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo1.Domain.Entities
{
    public class User : Entity
    {

        protected User()
        {

        }

        public User(string name, string email, string password)
        {
            SetPassword(password);
            SetEmail(email);
            this.Name = name;
        }

        public void SetPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new DomainException("Senha invalida");

            this.Password = SecurityEncrypt.Encrypt(password);
        }

        public void SetEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                throw new DomainException("Email invalido");

            // validacao de email
            this.Email = email;
        }


        public void Validate()
        {
            if (string.IsNullOrEmpty(this.Password))
                throw new DomainException("Senha invalida");

            if (string.IsNullOrEmpty(this.Name))
                throw new DomainException("Nome nao informado");

            if (string.IsNullOrEmpty(this.Email))
                throw new DomainException("Email nao informado");

            // outras validacoes
        }

        public string Name { get; protected set; }

        public string Password { get; protected set; }

        public string Email { get; protected set; }
    }
}
