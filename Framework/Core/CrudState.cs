using System;

namespace _3DFarmManager.Framework.Core
{
    /// <summary>
    /// Representa o estado atual da interface de um CRUD.
    /// </summary>
    public class CrudState
    {
        /// <summary>
        /// Estado atual da tela.
        /// </summary>
        public CrudMode Mode { get; private set; }

        /// <summary>
        /// Indica que existem alterações ainda não salvas.
        /// </summary>
        public bool IsDirty { get; private set; }

        /// <summary>
        /// Indica que existe uma operação em andamento.
        /// Enquanto estiver true a interface pode ser bloqueada.
        /// </summary>
        public bool IsBusy { get; private set; }

        public CrudState()
        {
            Mode = CrudMode.Empty;
            IsDirty = false;
            IsBusy = false;
        }

        /// <summary>
        /// Altera o modo atual da tela.
        /// </summary>
        public void SetMode(CrudMode mode)
        {
            Mode = mode;
        }

        /// <summary>
        /// Indica que existem alterações pendentes.
        /// </summary>
        public void MarkDirty()
        {
            IsDirty = true;
        }

        /// <summary>
        /// Limpa o indicador de alterações pendentes.
        /// </summary>
        public void ClearDirty()
        {
            IsDirty = false;
        }

        /// <summary>
        /// Indica que uma operação foi iniciada.
        /// </summary>
        public void BeginOperation()
        {
            IsBusy = true;
        }

        /// <summary>
        /// Indica que a operação terminou.
        /// </summary>
        public void EndOperation()
        {
            IsBusy = false;
        }

        /// <summary>
        /// Restaura o estado inicial.
        /// </summary>
        public void Reset()
        {
            Mode = CrudMode.Empty;
            IsDirty = false;
            IsBusy = false;
        }
    }
}