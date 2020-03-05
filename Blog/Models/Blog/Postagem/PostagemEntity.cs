using Blog.Models.Blog.Autor;
using Blog.Models.Blog.Categoria;
using Blog.Models.Blog.Etiqueta;
using Blog.Models.Blog.Postagem.Revisao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models.Blog.Postagem
{
    public class PostagemEntity
    {
        public string Titulo;
        public AutorEntity Autor;
        public CategoriaEntity Categoria;
        public List<EtiquetaEntity> Etiquetas;
        public List<RevisaoEntity> Revisoes;
        
        
        /* // Encapsulamento: private, protect, public
        public string Titulo;
        public AutorEntity Autor;

        // Para que esse método possa ser reescrito utiliza-se o "virtual"
        public virtual string editar()
        {
            return "edição realizada";
        }

    }

    // Criar herança "<ClasseNova> : <NomeClasse>"
    public class PostagemSobreFilmesEntity : PostagemEntity
    {
        public string Genero;

        // Polimorfismo reescreve o metodo editar porém com um retorno diferente
        // usa override
        public override string editar()
        {
            return "edição realizada na postagem sobre filmes";*/
    }
}

