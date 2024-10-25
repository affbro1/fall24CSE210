using System;

    class Reference
    {
        private Scripture[] scriptures;

        public Reference()
        {
            scriptures = new Scripture[]
            {
                new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
                new Scripture("Philippians 4:13", "I can do all this through him who gives me strength."),
                new Scripture("Psalm 23:1", "The Lord is my shepherd, I lack nothing."),
                new Scripture("Romans 8:28", "And we know that in all things God works for the good of those who love him, who have been called according to his purpose."),
                new Scripture("Philippians 4:13", "I can do all things through Christ which strengtheneth me."),
                new Scripture("1 Nephi 3:7", "I will go and do the things which the Lord hath commanded."),
                new Scripture("Mosiah 2:17", "When ye are in the service of your fellow beings ye are only in the service of your God."),
                new Scripture("Alma 37:37", "Counsel with the Lord in all thy doings, and he will direct thee for good."),
                new Scripture("Ether 12:27", "And if men come unto me I will show unto them their weakness."),
                new Scripture("Moroni 10:4-5", "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true."),
            };
        }

        public Scripture GetRandomScripture()
        {
            Random rand = new Random();
            int index = rand.Next(scriptures.Length);
            return scriptures[index];
        }
    }

