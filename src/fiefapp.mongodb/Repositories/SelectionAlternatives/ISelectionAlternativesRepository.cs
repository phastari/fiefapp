namespace fiefapp.mongodb.Repositories.SelectionAlternatives
{
    public interface ISelectionAlternativesRepository
    {
         entities.SelectionAlternatives Get();
         entities.SelectionAlternatives Get(string id);
    }
}
