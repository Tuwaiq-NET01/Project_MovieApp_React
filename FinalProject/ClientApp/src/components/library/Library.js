import React, {useEffect, useState} from 'react';
import axios from "axios";
import {Link, useHistory} from "react-router-dom";

function Library(props) {

    const [list, setList] = useState([]);
    const [user, setUser] = useState({});
    const [loading, setLoading] = useState(true);

    const history = useHistory();

    let addAndSearch;
    
    useEffect(() => {
        getList()
        getProfile()
        return () => {
            
        };
    },[]);

    const getList = () => {
        if (props.which == 1) {
            axios.get("https://localhost:5001/api/Movies", {
                withCredentials: true
            })
                .then(res => {
                    setLoading(false)
                    setList(res.data.list)
                })
                .catch(err => console.log(err))
        }
        else if (props.which == 2) {
            axios.get("https://localhost:5001/api/tvshows", {
                withCredentials: true
            })
                .then(res => {
                    setLoading(false)
                    setList(res.data.list)
                })
                .catch(err => console.log(err))
        }
    }
    
    const getProfile = () => {
        axios.get("https://localhost:5001/api/auth/user", {
            withCredentials: true,
        })
            .then((res) => {
                console.log(res)
                setUser(res.data)
            })
            .catch((err) => console.log(err));
    }

    const addToFav = (id) => {
        if (props.which == 1) {
            axios.post(`https://localhost:5001/api/favoritemovies/${id}`, {}, {withCredentials: true})
                .then(res => {
                    console.log(res);
                    getList();
                    getProfile()
                }).catch(err => console.log(err));
        }
        else if (props.which == 2) {
            axios.post(`https://localhost:5001/api/favoritetvshows/${id}`, {}, {
                withCredentials: true
            })
                .then(res => {
                    console.log(res);
                    getList();
                    getProfile()
                }).catch(err => console.log(err));
        }
    }

    const deleteFromFav = (id) => {
        if (props.which == 1) {
            axios.delete(`https://localhost:5001/api/favoritemovies/${id}`, {
                withCredentials: true,
            })
                .then(res => {
                    console.log(res);
                    getList();
                    getProfile();
                })
                .catch(err => console.log(err));
        } else if (props.which == 2) {
            axios.delete(`https://localhost:5001/api/favoritetvshows/${id}`, {
                withCredentials: true
            })
                .then(res => {
                    console.log(res);
                    getList();
                    getProfile();
                })
                .catch(err => console.log(err));
        }
    }

    const edit = (id) => {
            props.setId(id)
        if (props.which == 1) {
            history.push(`/edit-movie/${id}`, {id: id})
        } else if (props.which == 2) {
            history.push(`/edit-tvshow/${id}`, { id: id })
        }
    }
    
    const info = (id) => {
        props.setId(id)
        if (props.which == 1) {
            history.push(`/movie-info/${id}`, { id: id })
        } else if (props.which == 2) {
            history.push(`/tvshow-info/${id}`, {id: id})
        }
    }

    const redirect = (num) => {
        if (props.which == 1) {
            if (num === 1) {
                history.push("/add-new-movie");
            } else {
                history.push("/search-movie");
            }
        } else if (props.which == 2) {
            if(num === 1){
                history.push("/add-new-tvshow");
            } else {
                history.push("/search-tvshow");
            }
        }
    }

    if (Object.keys(user).length > 0) {
        addAndSearch = (
            <div>
                <button onClick={()=>redirect(1)} className="btn mySearchBtn " style={{marginTop: "30px", marginBottom: "20px", marginLeft: "20px"}}><i className="fas fa-plus fa-lg" ></i></button>

                <button onClick={()=>redirect(2)} className="btn mySearchBtn " style={{marginTop: "30px", marginBottom: "20px", marginLeft: "15px"}}>
                    <i className="fas fa-search fa-lg"></i></button>
            </div>
        );
    } else {
        addAndSearch = null;
    }

    let whichList;
    let header;
    const theList = (element) => {
        if (props.which == 1) {
            header = "Movies"
            return user.name ? <div>

                {(user.profile.movie !== null && user.profile.movie.find(mov => mov.id == element.id)) || user.profile.id == 1
                    ? <i className="far fa-edit fa-2x myActionBtn" onClick={() => edit(element.id)}
                         style={{marginRight: "20px"}}></i> : null}
                {user.profile.favoriteMovie !== null && user.profile.favoriteMovie.find(fav => fav.movieId == element.id)
                    ? <i className="fas fa-heart fa-2x myActionBtn" onClick={() => deleteFromFav(element.id)}></i>
                    : <i className="far fa-heart fa-2x myActionBtn" onClick={() => addToFav(element.id)}></i>

                }
            </div> : null

        } else if (props.which == 2) {
            header = "TV Shows"
            return user.name ? <div>

                {(user.profile.tvShow !== null && user.profile.tvShow.find(mov => mov.id == element.id)) || user.profile.id == 1
                    ? <i className="far fa-edit fa-2x myActionBtn" onClick={() => edit(element.id)}
                         style={{marginRight: "20px"}}></i> : null}
                {user.profile.favoriteTvShow !== null && user.profile.favoriteTvShow.find(fav => fav.tvShowId == element.id)
                    ? <i className="fas fa-heart fa-2x myActionBtn" onClick={() => deleteFromFav(element.id)}></i>
                    : <i className="far fa-heart fa-2x myActionBtn" onClick={() => addToFav(element.id)}></i>

                }
            </div> : null
        }
    }

    const renderList = (list) => {
        return (
            <div className="row row-cols-1 row-cols-md-4 g-4 fade-me">
                {list.map((element, index) =>
                    <div className="col " key={index} >
                        <div className="card hoverMe" style={{ borderRadius: "30px"}}>
                            <img src={element.poster} className="card-img-top" alt="..." style={{ borderRadius: "30px 30px 0px 0px"}}  onClick={() => info(element.id)}/>
                            <div className="card-body">
                                <h5 className="card-title" style={{paddingBottom: "20px"}}  onClick={() => info(element.id)}>{element.title}</h5>
                                <div className="card-text" style={{textAlign: "right"}}>
                                    {/*<button onClick={() => infoMovie(movie.id)} className="btn btn-info myBtn" style={{marginBottom: "20px"}}>Info</button>*/}

                                    {theList(element)}
                                </div>
                            </div>
                        </div>
                    </div>
                )}
            </div>
        );
    }

    let contents = loading
        ? <p><em>Loading...</em></p>
        : renderList(list);
        
    return (
        <div className="fade-me">
            <h1 id="tabelLabel" style={{textAlign: "center"}}>{header}</h1>
            {addAndSearch}
            {contents}
        </div>
    );
}

export default Library;