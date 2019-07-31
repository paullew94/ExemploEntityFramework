using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo00
{
    class Program
    {
        static void Main(string[] args)
        {
            SistemaContext contexto = new SistemaContext();

            #region inserir
            Animal animal = new Animal();
            animal.Nome = "TRex";
            animal.Extinto = true;

            contexto.Animais.Add(animal);
            contexto.SaveChanges();
            Console.WriteLine("Registro salvo com sucesso");
            #endregion inserir

            #region apagar
            //Animal animalApagar = contexto.Animais.Where(x=> x.Nome == "Zebra").First();
            //contexto.Animais.Remove(animalApagar);
            //contexto.SaveChanges();
            #endregion apagar

            #region alterar
            //var cachorro = contexto.Animais.First(x => x.Id == 4);
            //cachorro.Nome = "Cachorro";
            //contexto.SaveChanges();

            #endregion alterar

            #region listar
            //List<Animal> animais = contexto.Animais/*.Where(x=>x.Extinto== false && x.Nome.Contains("a"))*/.OrderBy(x=>x.Nome).ToList();
            //foreach(Animal animal2 in animais)
            //{
            //    Console.WriteLine($"{animal2.Id}-{animal2.Nome}- {animal2.Extinto}");
            //}
            #endregion listar

            #region InserirRelacionado
            Habilidades habilidade = new Habilidades();
            habilidade.IdAnimal = 1;
            habilidade.Nome="Invisibilidade";

            contexto.Habilitades.Add(habilidade);
            contexto.SaveChanges();

            var habilidades = contexto.Habilitades.Include("Animal").ToList();

            foreach(Habilidades habilitadeAux in habilidades)
            {
                Console.WriteLine(habilidadeAux.Animal.Nome+ "-"+ habilidadeAux.Nome);
            }
            #endregion InserirRealacionado
        }
    }
}
