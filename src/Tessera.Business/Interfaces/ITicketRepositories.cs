using Tessera.DataAccess.Models;

namespace Tessera.Business.Interfaces;
public interface ITicketRepositories
{
    void DeleteTicket(Ticket ticket);
    bool FindTickteById(string id);
    Ticket GetTicketById(string id);
    List<Ticket> GetTicketPerPage(int pageNumber, int totalNumber);
    Ticket InsertTicket(Ticket ticket);
    Ticket UpdateTicket(Ticket ticket);
}