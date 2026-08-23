using _3DFarmManager.Model;
using _3DFarmManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3DFarmManager.Validators
{
    internal class ColorValidator
    {
        public static List<string> Validate(ColorModel model)
        {
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(model.Name))
                errors.Add("-> Nome da cor obrigatório.");

            if (!ColorHexCodeValidator(model.ColorHexCode))
                errors.Add("-> Código hexadecimal inválido.");

            if (!ColorRgbCodeValidator(model.ColorRgbCode))
                errors.Add("-> Código RGB inválido.");

            return errors;
        }

        public static bool ColorHexCodeValidator(string cor)
        {
            // Padrão aceita #RGB, #RRGGBB, RGB ou RRGGBB
            string padrao = @"^#?([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})$";

            return Regex.IsMatch(cor, padrao);
        }

        public static bool ColorRgbCodeValidator(string cor)
        {
            // 1. Verifica se a string está vazia
            if (string.IsNullOrWhiteSpace(cor))
            {
                return false;
            }

            // 2. Divide o texto nos pontos e vírgulas
            string[] partes = cor.Split(';');

            // 3. Uma cor RGB precisa ter exatamente 3 partes (R, G e B)
            if (partes.Length != 3)
            {
                return false;
            }

            // 4. Valida cada um dos três canais
            foreach (string parte in partes)
            {
                // Tenta converter o texto em número inteiro
                if (!int.TryParse(parte.Trim(), out int valor))
                {
                    return false; // Não é um número válido
                }

                // O valor deve estar estritamente entre 0 e 255
                if (valor < 0 || valor > 255)
                {
                    return false; // Fora do intervalo de cor
                }
            }

            return true; // Passou em todas as validações
        }

    }
}
