using MVCArchitecure.Models;

namespace MVCArchitecure.Repository
{
    public interface ITutorialRepository
    {
        Tutorial Add(Tutorial tutorial);

        Tutorial Update(Tutorial tutorial);

        Tutorial Delete(int Id);

        Tutorial GetTutorial(int Id);

        IEnumerable<Tutorial> GetAllTutorial();
    }
}
