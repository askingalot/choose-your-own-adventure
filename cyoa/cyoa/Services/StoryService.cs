using System.Collections.Generic;
using System.Linq;
using cyoa.Models;

namespace cyoa.Services
{
    public class StoryService : IStoryService
    {
        public IEnumerable<StoryPart> TextToStoryParts(IEnumerable<string> lines)
        {
            return lines.Select(l => new StoryPart());
        }
    }
}
