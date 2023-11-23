namespace _01._Songs
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfSong = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();
            for (int i = 0; i < numberOfSong; i++)
            {
                string[] songComponents = Console.ReadLine().Split("_");
                string SongTypeList = songComponents[0]; ;
                string songName = songComponents[1];
                string songTime = songComponents[2];

                Song currentSong = new Song
                {
                    Name = songName,
                    TypeList = SongTypeList,
                    Time = songTime,
                };
                songs.Add(currentSong);
            }

            string command = Console.ReadLine();

            if (command != "all")
            {

                songs = songs.Where(x => x.TypeList == command).ToList();
                
            }

            foreach (Song song in songs)
            {
                Console.WriteLine(song.Name);
            }
        }
    }   
}
