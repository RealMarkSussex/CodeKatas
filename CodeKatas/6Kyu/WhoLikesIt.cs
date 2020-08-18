namespace CodeKatas._6Kyu
{
    class WhoLikesIt
    {
        public static string Likes(string[] name)
        {
            const string likes = "likes this";
            const string like = "like this";
            switch (name.Length)
            {
                case 0:
                    return $"no one {likes}";
                case 1:
                    return $"{name[0]} {likes}";
                case 2:
                    return $"{name[0]} and {name[1]} {like}";
                case 3:
                    return $"{name[0]}, {name[1]} and {name[2]} {like}";
                default:
                    return $"{name[0]}, {name[1]} and {name.Length - 2} others {like}";
            }
        }
    }
}
