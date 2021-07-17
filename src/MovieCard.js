import './App.css'
import React, {useState} from 'react'
import { useAlert } from "react-alert";

export const MovieCard = ({ Movie, MovieList, InMyFav , removeMovie }) => {
  const [Add, setAdd] = useState(!Movie.InMyList);
  const alert = useAlert();
  const addToFav = Movie => {
    Movie.InMyList = true;
    MovieList.push(Movie);
    alert.success("Added to List!");
    localStorage.setItem('MyMovies', MovieList);
    localStorage.setItem("LoggedIn", false);
  };

  const removeFromFav = Movie => {
    Movie.InMyList = false;
    removeMovie();
    alert.success("Removed from List!");
  };
  return (
    <div className="flip-card">
      <div className="flip-card-inner">
        <div className="flip-card-front">
          <img
            className="card-img-top"
            src={"https://image.tmdb.org/t/p/original" + Movie.poster_path}
            alt="data:image/png;base64,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"
            style={{ width: '200px', height: '300px' }}
          ></img>
        </div>
        <div className="flip-card-back text-white">
          <div className="">
            <h5>{Movie.original_title}</h5>
          </div>
          <div className="card-body text-black">
            <h6 className="card-title">Released: {Movie.release_date}</h6>
            <h6 className="card-title">Overview</h6>
            <dev className="text">{Movie.overview}</dev>
            
          </div>
          <div className="card-footer bg-transparent border-success">
          {
            InMyFav ? <button type="button" className="btn btn-danger bottom" onClick={() => removeFromFav(Movie)}>Remove From List</button> : <button type="button" disabled={!Add} onClick={() =>  {
              if(Add) addToFav(Movie);
              else removeFromFav(Movie);
              setAdd(!Add);
            }} className="btn btn-dark bottom">{Add && !InMyFav ? "Add to My List" : "In My List"}</button>
          }
          </div>
        </div>
      </div>
    </div>
  )
}