using System;
using System.IO;
using System.Linq;
using cyoa.Services;

namespace cyoa
{
    class Program
    {
        private const string STORY_FILENAME = "story.txt";

        static void Main(string[] args)
        {
            var storyLines = File.ReadAllLines(STORY_FILENAME).ToList();
            storyLines.ForEach(Console.WriteLine);
            
            var storySerivce = new StoryService();
            var storyParts = storySerivce.TextToStoryParts(storyLines);
        }
    }
}
