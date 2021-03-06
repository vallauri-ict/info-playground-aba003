﻿using System;

namespace _25_EreditarietàEsStagisti
{
    abstract class clsPersona
    {
        #region Attributi
        private string nome;
        private string cognome;
        private string città;
        #endregion

        public string Città
        {
            get => città;
            set
            {
                if (value.Trim().Length >= 2)
                {
                    città = value;
                }
                else
                {
                    throw new Exception("Città non valida");
                }
            }
        }
        public string Cognome
        {
            get => cognome;
            set
            {
                if (value.Trim().Length >= 2)
                {
                    cognome = value;
                }
                else
                {
                    throw new Exception("Cognome non valido");
                }
            }
        }
        public string Nome
        {
            get => nome;
            set
            {
                if (value.Trim().Length >= 2)
                {
                    nome = value;
                }
                else
                {
                    throw new Exception("Nome non valido");
                }
            }
        }
        protected clsPersona(string nome, string cognome, string città)
        {
            Nome = nome;
            Cognome = cognome;
            Città = città;
        }
        public abstract string visualizza();
    }
}
