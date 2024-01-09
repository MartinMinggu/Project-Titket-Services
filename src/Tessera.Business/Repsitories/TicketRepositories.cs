using Tessera.Business.Interfaces;
using Tessera.DataAccess.Models;

namespace Tessera.Business.Repsitories;
public class TicketRepositories : ITicketRepositories {
    private static TesseraContext _tesseraContext;

    public TicketRepositories(TesseraContext tesseraContext) {
        _tesseraContext = tesseraContext;
    }
    public List<Ticket> GetTicketPerPage(int pageNumber, int totalNumber) {
        return _tesseraContext.Tickets.Skip(pageNumber * totalNumber).Take(totalNumber).ToList();
    }
    public Ticket InsertTicket(Ticket ticket) {
        _tesseraContext.Add(ticket);
        return ticket;
    }
    public Ticket UpdateTicket(Ticket ticket) {
        _tesseraContext.Add(ticket);
        return ticket;
    }
    public void DeleteTicket(Ticket ticket) {
        _tesseraContext.Remove(ticket);
        _tesseraContext.SaveChanges();
    }
    public Ticket GetTicketById(string id) {
        return _tesseraContext.Tickets.FirstOrDefault(t => t.Id == id);
    }
    public bool FindTickteById(string id) {
        return _tesseraContext.Tickets.Any(t => t.Id == id);
    }

}
