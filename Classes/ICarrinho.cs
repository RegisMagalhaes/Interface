namespace POO_Interface.Classes
{
    public interface ICarrinho
    {
         // CRUD

         // - Criate - Cadastrar

        void Cadastrar(Produto produto);

         // - Read - Ler

         void Listar();

         // - Update - Alterar

         void Alterar(int codigo, Produto produto);


         // - Delete

         void Deletar(Produto produto);


    }
}