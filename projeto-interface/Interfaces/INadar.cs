namespace projeto_interface.Interfaces
{
    internal interface INadar
    {
        public int LimiteProfundidade { get; set; }
        void Mergulhar(int metros);
        void Subir(int metros);
    }
}
