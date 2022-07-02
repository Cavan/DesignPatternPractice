using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternImplementation.Patterns.Creational
{
    /// The Factory Method Design Pattern
   
    ///<summary>
    /// The 'Product' abstract class
    /// </summary>
    abstract class Page
    {

    }

    /// <summary>
    /// A 'ConcreteProdut' class
    /// </summary>
    class SkillsPage : Page
    {

    }

    /// <summary>
    /// A 'ConcreteProdut' class
    /// </summary>
    class EducationPage : Page
    {

    }

    /// <summary>
    /// A 'ConcreteProdut' class
    /// </summary>
    class ExperiencePage : Page
    {

    }

    /// <summary>
    /// A 'ConcreteProdut' class
    /// </summary>
    class IntroductionPage : Page
    {

    }

    /// <summary>
    /// A 'ConcreteProdut' class
    /// </summary>
    class ResultsPage : Page
    {

    }

    /// <summary>
    /// A 'ConcreteProdut' class
    /// </summary>
    class ConclusionPage : Page
    {

    }

    /// <summary>
    /// A 'ConcreteProdut' class
    /// </summary>
    class SummaryPage : Page
    {

    }

    /// <summary>
    /// A 'ConcreteProdut' class
    /// </summary>
    class BibliographyPage : Page
    {

    }

    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    abstract class Document
    {
        private List<Page> _pages = new List<Page>();

        // Constructor calls abstract Factory method
        public Document()
        {
            this.CreatePages();
        }

        public List<Page> Pages
        {
            get { return _pages; }
        }

        // Factory Method
        public abstract void CreatePages();
    }

    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    class Resume : Document
    {
        // Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }

    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    class Report : Document
    {
        // Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new SummaryPage());
            Pages.Add(new BibliographyPage());
        }
    }
}
