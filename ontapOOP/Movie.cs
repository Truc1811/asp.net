class Movie{
    private string movieId;
    public string MovieId{
        get{
            return movieId;
        }
        set{
            movieId = value;
        }
    }
    
    private string title;
    public string Title{
        get{
            return title;
        }
        set{
            title = value;
        }
    
    }

    private string director;
    public string Director{
        get{
            return director;
        }
        set{
            director = value;
        }
    }

    private int duration;
    public int Duration{
        get{
            return duration;
        }
        set{
            duration = value;
        }
    }

    private int rating;
    public int Rating{
        get{
            return rating;
        }
        set{
            rating = value;
        }
    }

    public Movie(
        string movieId,
        string title,
        string director,
        int duration,
        int rating

    ){
        MovieId = movieId;
        Title=title;
        Director=director;
        Duration=duration;
        Rating=rating;
    }
}