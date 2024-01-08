﻿using MVCArchitecure.Context;
using MVCArchitecure.Models;

namespace MVCArchitecure.Repository
{
    public class TutorialRepository : ITutorialRepository
    {
        //private List<Tutorial> _tutorials;

        private readonly TutorialDbContext _context;

        public TutorialRepository(TutorialDbContext context)
        { 
            ////Temporarily we are going to create mock data
            //_tutorials = new List<Tutorial>()
            //{
            //    new Tutorial(){Id=1, Name="C#", Description="C# Tutorial"},
            //    new Tutorial(){Id=2,Name="Asp.net core", Description="Asp.net Core Tutorial"}
            //};

            _context = context;
        } 
       public Tutorial Add(Tutorial tutorial)
        {
            _context.Tutorials.Add(tutorial);
            _context.SaveChanges();
            return tutorial;
        }

        public Tutorial Delete(int Id)
        {
            Tutorial tutorial = _context.Tutorials.Find(Id);

            if(tutorial != null)
            {
                _context.Tutorials.Remove(tutorial);
                _context.SaveChanges();
            }
            return tutorial;
        }

        public IEnumerable<Tutorial> GetAllTutorial()
        {
            return _context.Tutorials;
        }



        public Tutorial GetTutorial(int Id) 
        {
            return _context.Tutorials.Find(Id);
        }

        public Tutorial Update(Tutorial tutorialModified
            )
        {
            _context.Update(tutorialModified);
            _context.SaveChanges();
            return tutorialModified;
        }

       
    }
}
