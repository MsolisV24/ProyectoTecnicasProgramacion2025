using ClassModels;
using Microsoft.EntityFrameworkCore;

namespace ClassDataAccess
{
    public class DatabaseInitializer
    {
        private readonly DatabaseContext _context;

        public DatabaseInitializer(DatabaseContext context)
        {
            _context = context;
        }

        public void Initialize()
        {
            _context.Database.EnsureCreated();
            SeedRealData();
        }

        private void SeedRealData()
        {
            if (!_context.Fairs.Any())
            {
                var fairs = new List<Fair>
                {
                    new Fair { Id = 1, Name = "Feria Zapote", Province = "San José" },
                    new Fair { Id = 2, Name = "Feria Guadalupe", Province = "San José" },
                    new Fair { Id = 3, Name = "Feria Curridabat", Province = "San José" },
                    new Fair { Id = 4, Name = "Feria Heredia", Province = "Heredia" },
                    new Fair { Id = 5, Name = "Feria Alajuela", Province = "Alajuela" }
                };
                _context.Fairs.AddRange(fairs);
            }

            if (!_context.Producers.Any())
            {
                var producers = new List<Producer>
                {
                    new Producer { Id = 1, Name = "Productor Mario" },
                    new Producer { Id = 2, Name = "Productora Ana" },
                    new Producer { Id = 3, Name = "Productor Luis" },
                    new Producer { Id = 4, Name = "Productor Carlos" },
                    new Producer { Id = 5, Name = "Productor Jorge" },
                    new Producer { Id = 6, Name = "Productor Ernesto" },
                    new Producer { Id = 7, Name = "Productor Allan" },
                    new Producer { Id = 8, Name = "Productor Felipe" },
                    new Producer { Id = 9, Name = "Productora Sofia" },
                    new Producer { Id = 10, Name = "Productora Daniela" },
                    new Producer { Id = 11, Name = "Productor Miguel" },
                    new Producer { Id = 12, Name = "Productora Laura" },
                    new Producer { Id = 13, Name = "Productor José" },
                    new Producer { Id = 14, Name = "Productor Tito" },
                    new Producer { Id = 15, Name = "Productora Mariela" },
                    new Producer { Id = 16, Name = "Productor Beto" },
                    new Producer { Id = 17, Name = "Productora Karina" },
                    new Producer { Id = 18, Name = "Productor Andres" },
                    new Producer { Id = 19, Name = "Productor Fabian" },
                    new Producer { Id = 20, Name = "Productor Gabriel" },
                    new Producer { Id = 21, Name = "Productora Irene" },
                    new Producer { Id = 22, Name = "Productora Fabiola" },
                    new Producer { Id = 23, Name = "Productor Ricardo" },
                    new Producer { Id = 24, Name = "Productora Tania" },
                    new Producer { Id = 25, Name = "Productor Henry" },
                    new Producer { Id = 26, Name = "Productor Adrián" },
                    new Producer { Id = 27, Name = "Productor Cristian" },
                    new Producer { Id = 28, Name = "Productora Natalia" },
                    new Producer { Id = 29, Name = "Productor Esteban" },
                    new Producer { Id = 30, Name = "Productora Silvia" }
                };
                _context.Producers.AddRange(producers);
            }

            if (!_context.Products.Any())
            {
                var products = new List<Product>
                {
                    new Product { Id = 1, ProducerId = 1, FairId = 1, Name = "Tomate", Unit = "kg", UnitPrice = 900, Price = 900 },
                    new Product { Id = 2, ProducerId = 1, FairId = 1, Name = "Cebolla", Unit = "kg", UnitPrice = 800, Price = 800 },
                    new Product { Id = 3, ProducerId = 2, FairId = 1, Name = "Zanahoria", Unit = "kg", UnitPrice = 600, Price = 600 },
                    new Product { Id = 4, ProducerId = 3, FairId = 1, Name = "Lechuga", Unit = "unidad", UnitPrice = 350, Price = 350 },
                    new Product { Id = 5, ProducerId = 4, FairId = 2, Name = "Apio", Unit = "manojo", UnitPrice = 500, Price = 500 },
                    new Product { Id = 6, ProducerId = 4, FairId = 2, Name = "Papa", Unit = "kg", UnitPrice = 700, Price = 700 },
                    new Product { Id = 7, ProducerId = 5, FairId = 2, Name = "Culantro", Unit = "manojo", UnitPrice = 300, Price = 300 },
                    new Product { Id = 8, ProducerId = 6, FairId = 2, Name = "Berenjena", Unit = "kg", UnitPrice = 1000, Price = 1000 },
                    new Product { Id = 9, ProducerId = 7, FairId = 3, Name = "Repollo", Unit = "unidad", UnitPrice = 750, Price = 750 },
                    new Product { Id = 10, ProducerId = 8, FairId = 3, Name = "Chile Dulce", Unit = "unidad", UnitPrice = 250, Price = 250 },
                    new Product { Id = 11, ProducerId = 9, FairId = 3, Name = "Pepino", Unit = "unidad", UnitPrice = 200, Price = 200 },
                    new Product { Id = 12, ProducerId = 10, FairId = 3, Name = "Limón", Unit = "kg", UnitPrice = 900, Price = 900 },
                    new Product { Id = 13, ProducerId = 11, FairId = 4, Name = "Naranja", Unit = "kg", UnitPrice = 650, Price = 650 },
                    new Product { Id = 14, ProducerId = 12, FairId = 4, Name = "Manzana", Unit = "kg", UnitPrice = 1200, Price = 1200 },
                    new Product { Id = 15, ProducerId = 13, FairId = 4, Name = "Pera", Unit = "kg", UnitPrice = 1300, Price = 1300 },
                    new Product { Id = 16, ProducerId = 14, FairId = 4, Name = "Plátano", Unit = "kg", UnitPrice = 500, Price = 500 },
                    new Product { Id = 17, ProducerId = 15, FairId = 5, Name = "Aguacate", Unit = "unidad", UnitPrice = 1200, Price = 1200 },
                    new Product { Id = 18, ProducerId = 16, FairId = 5, Name = "Mandarina", Unit = "kg", UnitPrice = 700, Price = 700 },
                    new Product { Id = 19, ProducerId = 17, FairId = 5, Name = "Maracuyá", Unit = "kg", UnitPrice = 1500, Price = 1500 },
                    new Product { Id = 20, ProducerId = 18, FairId = 5, Name = "Guayaba", Unit = "kg", UnitPrice = 800, Price = 800 },
                    new Product { Id = 21, ProducerId = 19, FairId = 1, Name = "Uvas", Unit = "kg", UnitPrice = 2500, Price = 2500 },
                    new Product { Id = 22, ProducerId = 20, FairId = 1, Name = "Fresas", Unit = "kg", UnitPrice = 3000, Price = 3000 },
                    new Product { Id = 23, ProducerId = 21, FairId = 2, Name = "Banano", Unit = "kg", UnitPrice = 500, Price = 500 },
                    new Product { Id = 24, ProducerId = 22, FairId = 2, Name = "Mango", Unit = "unidad", UnitPrice = 900, Price = 900 },
                    new Product { Id = 25, ProducerId = 23, FairId = 3, Name = "Melón", Unit = "kg", UnitPrice = 900, Price = 900 },
                    new Product { Id = 26, ProducerId = 24, FairId = 3, Name = "Sandía", Unit = "kg", UnitPrice = 650, Price = 650 },
                    new Product { Id = 27, ProducerId = 25, FairId = 4, Name = "Piña", Unit = "unidad", UnitPrice = 1200, Price = 1200 },
                    new Product { Id = 28, ProducerId = 26, FairId = 4, Name = "Remolacha", Unit = "kg", UnitPrice = 600, Price = 600 },
                    new Product { Id = 29, ProducerId = 27, FairId = 5, Name = "Arroz", Unit = "kg", UnitPrice = 750, Price = 750 },
                    new Product { Id = 30, ProducerId = 28, FairId = 5, Name = "Frijoles", Unit = "kg", UnitPrice = 1400, Price = 1400 },
                    new Product { Id = 31, ProducerId = 29, FairId = 1, Name = "Huevo", Unit = "unidad", UnitPrice = 120, Price = 120 },
                    new Product { Id = 32, ProducerId = 30, FairId = 1, Name = "Leche", Unit = "litro", UnitPrice = 900, Price = 900 },
                    new Product { Id = 33, ProducerId = 1, FairId = 2, Name = "Yuca", Unit = "kg", UnitPrice = 450, Price = 450 },
                    new Product { Id = 34, ProducerId = 2, FairId = 3, Name = "Cacao", Unit = "kg", UnitPrice = 2200, Price = 2200 },
                    new Product { Id = 35, ProducerId = 3, FairId = 4, Name = "Maíz", Unit = "kg", UnitPrice = 400, Price = 400 },
                    new Product { Id = 36, ProducerId = 4, FairId = 5, Name = "Acelga", Unit = "manojo", UnitPrice = 550, Price = 550 },
                    new Product { Id = 37, ProducerId = 5, FairId = 1, Name = "Batata", Unit = "kg", UnitPrice = 500, Price = 500 },
                    new Product { Id = 38, ProducerId = 6, FairId = 2, Name = "Albahaca", Unit = "manojo", UnitPrice = 450, Price = 450 },
                    new Product { Id = 39, ProducerId = 7, FairId = 3, Name = "Romero", Unit = "manojo", UnitPrice = 500, Price = 500 },
                    new Product { Id = 40, ProducerId = 8, FairId = 4, Name = "Orégano", Unit = "manojo", UnitPrice = 600, Price = 600 }
                };
                _context.Products.AddRange(products);
            }

            if (!_context.InventoryItems.Any())
            {
                var inventory = new List<InventoryItem>
                {
                    new InventoryItem { Id = 1, ProductId = 1, QuantityAvailable = 100 },
                    new InventoryItem { Id = 2, ProductId = 2, QuantityAvailable = 80 },
                    new InventoryItem { Id = 3, ProductId = 3, QuantityAvailable = 60 },
                    new InventoryItem { Id = 4, ProductId = 4, QuantityAvailable = 150 },
                    new InventoryItem { Id = 5, ProductId = 5, QuantityAvailable = 100 },
                    new InventoryItem { Id = 6, ProductId = 6, QuantityAvailable = 70 },
                    new InventoryItem { Id = 7, ProductId = 7, QuantityAvailable = 200 },
                    new InventoryItem { Id = 8, ProductId = 8, QuantityAvailable = 50 },
                    new InventoryItem { Id = 9, ProductId = 9, QuantityAvailable = 60 },
                    new InventoryItem { Id = 10, ProductId = 10, QuantityAvailable = 100 },
                    new InventoryItem { Id = 11, ProductId = 11, QuantityAvailable = 120 },
                    new InventoryItem { Id = 12, ProductId = 12, QuantityAvailable = 150 },
                    new InventoryItem { Id = 13, ProductId = 13, QuantityAvailable = 60 },
                    new InventoryItem { Id = 14, ProductId = 14, QuantityAvailable = 80 },
                    new InventoryItem { Id = 15, ProductId = 15, QuantityAvailable = 70 },
                    new InventoryItem { Id = 16, ProductId = 16, QuantityAvailable = 100 },
                    new InventoryItem { Id = 17, ProductId = 17, QuantityAvailable = 40 },
                    new InventoryItem { Id = 18, ProductId = 18, QuantityAvailable = 90 },
                    new InventoryItem { Id = 19, ProductId = 19, QuantityAvailable = 30 },
                    new InventoryItem { Id = 20, ProductId = 20, QuantityAvailable = 100 },
                    new InventoryItem { Id = 21, ProductId = 21, QuantityAvailable = 40 },
                    new InventoryItem { Id = 22, ProductId = 22, QuantityAvailable = 30 },
                    new InventoryItem { Id = 23, ProductId = 23, QuantityAvailable = 200 },
                    new InventoryItem { Id = 24, ProductId = 24, QuantityAvailable = 80 },
                    new InventoryItem { Id = 25, ProductId = 25, QuantityAvailable = 70 },
                    new InventoryItem { Id = 26, ProductId = 26, QuantityAvailable = 50 },
                    new InventoryItem { Id = 27, ProductId = 27, QuantityAvailable = 30 },
                    new InventoryItem { Id = 28, ProductId = 28, QuantityAvailable = 100 },
                    new InventoryItem { Id = 29, ProductId = 29, QuantityAvailable = 200 },
                    new InventoryItem { Id = 30, ProductId = 30, QuantityAvailable = 150 },
                    new InventoryItem { Id = 31, ProductId = 31, QuantityAvailable = 300 },
                    new InventoryItem { Id = 32, ProductId = 32, QuantityAvailable = 200 },
                    new InventoryItem { Id = 33, ProductId = 33, QuantityAvailable = 120 },
                    new InventoryItem { Id = 34, ProductId = 34, QuantityAvailable = 60 },
                    new InventoryItem { Id = 35, ProductId = 35, QuantityAvailable = 100 },
                    new InventoryItem { Id = 36, ProductId = 36, QuantityAvailable = 90 },
                    new InventoryItem { Id = 37, ProductId = 37, QuantityAvailable = 70 },
                    new InventoryItem { Id = 38, ProductId = 38, QuantityAvailable = 100 },
                    new InventoryItem { Id = 39, ProductId = 39, QuantityAvailable = 110 },
                    new InventoryItem { Id = 40, ProductId = 40, QuantityAvailable = 140 }
                };
                _context.InventoryItems.AddRange(inventory);
            }

            if (!_context.Customers.Any())
            {
                var customers = new List<Customer>
                {
                    new Customer { Id = 1, Name = "Daniela", LastName = "Soto", Username = "dsoto", Password = "123", Directions = "[]" },
            new Customer { Id = 2, Name = "Edgar", LastName = "Ramírez", Username = "eramirez", Password = "123", Directions = "[]" },
            new Customer { Id = 3, Name = "Lucía", LastName = "Mora", Username = "lmora", Password = "123", Directions = "[]" },
            new Customer { Id = 4, Name = "Andrés", LastName = "Vargas", Username = "avargas", Password = "123", Directions = "[]" },
            new Customer { Id = 5, Name = "Sofía", LastName = "Aguilar", Username = "saguilar", Password = "123", Directions = "[]" },
            new Customer { Id = 6, Name = "Mario", LastName = "Solís", Username = "msolis", Password = "123", Directions = "[]" },
            new Customer { Id = 7, Name = "Paula", LastName = "Camacho", Username = "pcamacho", Password = "123", Directions = "[]" },
            new Customer { Id = 8, Name = "Erick", LastName = "Gómez", Username = "egomez", Password = "123", Directions = "[]" },
            new Customer { Id = 9, Name = "Jimena", LastName = "Leiva", Username = "jleiva", Password = "123", Directions = "[]" },
            new Customer { Id = 10, Name = "Carlos", LastName = "Rojas", Username = "crojas", Password = "123", Directions = "[]" },
            new Customer { Id = 11, Name = "Fabiola", LastName = "Méndez", Username = "fmendez", Password = "123", Directions = "[]" },
            new Customer { Id = 12, Name = "Luis", LastName = "Araya", Username = "laraya", Password = "123", Directions = "[]" },
            new Customer { Id = 13, Name = "Valeria", LastName = "Esquivel", Username = "vesquivel", Password = "123", Directions = "[]" },
            new Customer { Id = 14, Name = "Jorge", LastName = "Navarro", Username = "jnavarro", Password = "123", Directions = "[]" },
            new Customer { Id = 15, Name = "Karina", LastName = "Obando", Username = "kobando", Password = "123", Directions = "[]" },
            new Customer { Id = 16, Name = "Samuel", LastName = "Bolaños", Username = "sbolanos", Password = "123", Directions = "[]" },
            new Customer { Id = 17, Name = "Isabella", LastName = "Castro", Username = "icastro", Password = "123", Directions = "[]" },
            new Customer { Id = 18, Name = "Diego", LastName = "Fernández", Username = "dfernandez", Password = "123", Directions = "[]" },
            new Customer { Id = 19, Name = "Nicole", LastName = "Badilla", Username = "nbadilla", Password = "123", Directions = "[]" },
            new Customer { Id = 20, Name = "Alejandro", LastName = "Céspedes", Username = "acespedes", Password = "123", Directions = "[]" },
            new Customer { Id = 21, Name = "Patricia", LastName = "Blanco", Username = "pblanco", Password = "123", Directions = "[]" },
            new Customer { Id = 22, Name = "Rodrigo", LastName = "Cubero", Username = "rcubero", Password = "123", Directions = "[]" },
            new Customer { Id = 23, Name = "Gabriela", LastName = "Jiménez", Username = "gjimenez", Password = "123", Directions = "[]" },
            new Customer { Id = 24, Name = "Tomás", LastName = "Chaves", Username = "tchaves", Password = "123", Directions = "[]" },
            new Customer { Id = 25, Name = "Rebeca", LastName = "Fallas", Username = "rfallas", Password = "123", Directions = "[]" },
            new Customer { Id = 26, Name = "David", LastName = "Herrera", Username = "dherrera", Password = "123", Directions = "[]" },
            new Customer { Id = 27, Name = "Camila", LastName = "Solano", Username = "csolano", Password = "123", Directions = "[]" },
            new Customer { Id = 28, Name = "Sebastián", LastName = "Villalobos", Username = "svillalobos", Password = "123", Directions = "[]" },
            new Customer { Id = 29, Name = "Mariana", LastName = "Carrillo", Username = "mcarrillo", Password = "123", Directions = "[]" },
            new Customer { Id = 30, Name = "Esteban", LastName = "Loaiza", Username = "eloaiza", Password = "123", Directions = "[]" },
            new Customer { Id = 31, Name = "Silvia", LastName = "Torres", Username = "storres", Password = "123", Directions = "[]" },
            new Customer { Id = 32, Name = "Rafael", LastName = "Valverde", Username = "rvalverde", Password = "123", Directions = "[]" },
            new Customer { Id = 33, Name = "Laura", LastName = "Rivera", Username = "lrivera", Password = "123", Directions = "[]" },
            new Customer { Id = 34, Name = "Cristian", LastName = "Rodríguez", Username = "crodriguez", Password = "123", Directions = "[]" },
            new Customer { Id = 35, Name = "Katherine", LastName = "Monge", Username = "kmonge", Password = "123", Directions = "[]" },
            new Customer { Id = 36, Name = "Pablo", LastName = "Cordero", Username = "pcordero", Password = "123", Directions = "[]" },
            new Customer { Id = 37, Name = "Natalia", LastName = "Salas", Username = "nsalas", Password = "123", Directions = "[]" },
            new Customer { Id = 38, Name = "Fernando", LastName = "Campos", Username = "fcampos", Password = "123", Directions = "[]" },
            new Customer { Id = 39, Name = "Elena", LastName = "Ramírez", Username = "eramirez2", Password = "123", Directions = "[]" },
            new Customer { Id = 40, Name = "Victor", LastName = "Sequeira", Username = "vsequeira", Password = "123", Directions = "[]" },
            new Customer { Id = 41, Name = "Yuliana", LastName = "Vargas", Username = "yvargas", Password = "123", Directions = "[]" },
            new Customer { Id = 42, Name = "Mauricio", LastName = "Fonseca", Username = "mfonseca", Password = "123", Directions = "[]" },
            new Customer { Id = 43, Name = "Michelle", LastName = "García", Username = "mgarcia", Password = "123", Directions = "[]" },
            new Customer { Id = 44, Name = "Oscar", LastName = "Solís", Username = "osolis", Password = "123", Directions = "[]" },
            new Customer { Id = 45, Name = "Daniela", LastName = "Chacón", Username = "dchacon", Password = "123", Directions = "[]" },
            new Customer { Id = 46, Name = "Alonso", LastName = "Rodríguez", Username = "arodriguez", Password = "123", Directions = "[]" },
            new Customer { Id = 47, Name = "Gabriel", LastName = "Moya", Username = "gmoya", Password = "123", Directions = "[]" },
            new Customer { Id = 48, Name = "Adriana", LastName = "Porras", Username = "aporras", Password = "123", Directions = "[]" },
            new Customer { Id = 49, Name = "Héctor", LastName = "Sandí", Username = "hsandi", Password = "123", Directions = "[]" },
            new Customer { Id = 50, Name = "Edwin", LastName = "Zeledon", Username = "ezeledon", Password = "123", Directions = "[]" }
                };
                _context.Customers.AddRange(customers);
            }

            _context.SaveChanges();
        }
    }
}
