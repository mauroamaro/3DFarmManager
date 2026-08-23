using System.Collections.Generic;

namespace _3DFarmManager.Framework.Core
{
    /// <summary>
    /// Representa o resultado de uma operação do Framework.
    /// </summary>
    public class CrudOperationResult
    {
        /// <summary>
        /// Indica se a operação foi concluída com sucesso.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Mensagem principal da operação.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Identificador do registro afetado.
        /// </summary>
        public long? Id { get; set; }

        /// <summary>
        /// Lista de mensagens de erro.
        /// </summary>
        public List<string> Errors { get; }

        /// <summary>
        /// Indica se existem erros registrados.
        /// </summary>

        public enum CrudOperation
        {
            None,
            Insert,
            Update,
            Delete
        }

        public CrudOperation Operation
        {
            get;
            set;
        }

        public bool HasErrors
        {
            get
            {
                return Errors.Count > 0;
            }
        }

        public CrudOperationResult()
        {
            Message = string.Empty;
            Errors = new List<string>();
        }

        /// <summary>
        /// Cria um resultado de sucesso.
        /// </summary>
        public static CrudOperationResult Ok(
            string message = "",
            long? id = null)
        {
            return new CrudOperationResult
            {
                Success = true,
                Message = message,
                Id = id
            };
        }

        /// <summary>
        /// Cria um resultado de erro.
        /// </summary>
        public static CrudOperationResult Fail(
            params string[] errors)
        {
            CrudOperationResult result =
                new CrudOperationResult();

            result.Success = false;

            if (errors != null)
            {
                result.Errors.AddRange(errors);

                if (errors.Length > 0)
                    result.Message = errors[0];
            }

            return result;
        }

        /// <summary>
        /// Adiciona uma mensagem de erro.
        /// </summary>
        public void AddError(string error)
        {
            if (string.IsNullOrWhiteSpace(error))
                return;

            Errors.Add(error);

            if (string.IsNullOrWhiteSpace(Message))
                Message = error;

            Success = false;
        }

        /// <summary>
        /// Limpa todas as mensagens de erro.
        /// </summary>
        public void ClearErrors()
        {
            Errors.Clear();
        }
    }
}