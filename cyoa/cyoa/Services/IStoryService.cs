using System.Collections.Generic;
using cyoa.Models;

namespace cyoa.Services
{
    public interface IStoryService
    {
        IEnumerable<StoryPart> TextToStoryParts(IEnumerable<string> lines);
    }
}