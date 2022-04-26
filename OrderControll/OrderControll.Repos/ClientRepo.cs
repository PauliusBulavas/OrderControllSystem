using OrderControll.Common;
using OrderControll.Repos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public Client GetClientsById(int clientId)
        {
            var actualClient = Clients.FirstOrDefault(x => x.Id == clientId);

            return actualClient;
        }

        public void AddClient(Client client)
        {
            client.Id = Clients.LastOrDefault().Id + 1;
            Clients.Add(client);
        }

        public bool RemoveClient(int id)
        {
            return Clients.Remove(GetClientsById(id));
        }
    }
}