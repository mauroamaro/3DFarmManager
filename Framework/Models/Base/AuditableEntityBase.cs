using System;

namespace _3DFarmManager.Framework.Models
{
    /// <summary>
    /// Classe base para entidades que possuem informações de auditoria.
    /// </summary>
    public abstract class AuditableEntityBase : EntityBase
    {
        /// <summary>
        /// Data de criação.
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Usuário responsável pela criação.
        /// </summary>
        public long? CreatedBy { get; set; }

        /// <summary>
        /// Data da última alteração.
        /// </summary>
        //public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Usuário responsável pela última alteração.
        /// </summary>
        public long? UpdatedBy { get; set; }

        /// <summary>
        /// Indica se o registro foi excluído logicamente.
        /// </summary>
        public bool Deleted { get; set; }

        public DateTime? LogCrudDate { get; set; }

        public string LogUserName { get; set; }

        public int? LogCrudUserId { get; set; }

        public string LogCrudType { get; set; }

        public string LogCrudTypeDescription
        {
            get
            {
                if (string.IsNullOrWhiteSpace(LogCrudType))
                    return "";

                switch (LogCrudType)
                {
                    case "1":
                        return "Inclusão";

                    case "2":
                        return "Alteração";

                    case "3":
                        return "Exclusão";

                    default:
                        return "";
                }
            }
        }

    }
}
