using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interpress.Library.ReconstructorEngine.InElements;
using Interpress.Library.ReconstructorEngine.OutElements;
using Interpress.Library.ReconstructorEngine.Templates;

namespace Interpress.Library.ReconstructorEngine
{
    public class ReEngine
    {
        private IList<InPage> pages;
        private IList<BaseTemplate> allTemplates = new List<BaseTemplate>();
        private Queue<BaseTemplate> selectedTemplates = new Queue<BaseTemplate>();

        public ReEngine(IList<InPage> pages)
        {
            this.pages = pages;
                    allTemplates.Add(new HeaderTextsImages());
                    // allTemplates.Add(new HeaderImagesTexts());
                    //allTemplates.Add(new HeaderImageFooterText());
                    //allTemplates.Add(new HeaderText());
           
            foreach (var template in allTemplates)
                if (template.CanProcess(pages))
                    selectedTemplates.Enqueue(template);
        }

        public IList<OutPage> Process()
        {
            var templateNext = selectedTemplates.Dequeue();
            return templateNext.Process(pages);
        }

        public bool CanNextProcess()
        {
            return selectedTemplates.Count > 0;
        }
    }
}
