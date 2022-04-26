using OrderControll.Common;
using OrderControll.Repos.Entities;
using System.Collections.Generic;

namespace OrderControll.Repos
{
    public class ClientRepo
    {
        private List<Client> Clients { get; set; }

        public ClientRepo()
        {
            string fileName = FileReaderService.GetPathToResource("ClientsRepository.txt");
            Clients = new FileReaderService().Import<Client>(fileName);
        }

        public List<Client> GetClients() => Clients;
    }
}