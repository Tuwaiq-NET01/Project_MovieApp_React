import React, {useEffect, useState} from 'react';
import axios from "axios";
import "./info.css"

function Info(props) {

    const [element, setElement] = useState({});
    const [reviews, setReviews] = useState({});
    const [newReviewText, setNewReviewText] = useState("");
    const [newReviewSpoiler, setNewReviewSpoiler] = useState(false);

    useEffect(() => {
        if (props.which == 1){
            console.log(props.id)
            axios.get(`https://localhost:5001/api/movies/${props.id}`)
                .then(res => {
                    const list = res.data.movie;
                    const revi = res.data.reviewDto
                    setElement(list);
                    setReviews(revi);
                    console.log(list)
                    console.log(revi)
                }).catch(err => {
                console.log(err)
            })
        } else if (props.which == 2) {
            axios.get(`https://localhost:5001/api/tvshows/${props.id}`)
                .then(res => {
                    const list = res.data.tvShow;
                    const revi = res.data.reviewDto
                    setElement(list);
                    setReviews(revi);
                }).catch(err => {
                console.log(err)
            })
        }
        return () => {
        }
    }, [])

    const submit = (e) => {
        e.preventDefault();

        if (props.which == 1) {
            axios
                .post(
                    "https://localhost:5001/api/MovieReviews",
                    {
                        "text": newReviewText,
                        "spoiler": newReviewSpoiler,
                        "movieid": element.id
                    },
                    {
                        withCredentials: true,
                    }
                )
                .then((res) => {
                    console.log(res)
                    axios.get(`https://localhost:5001/api/movies/${props.id}`)
                        .then(res => {
                            const list = res.data.movie;
                            const revi = res.data.reviewDto
                            setElement(list);
                            setReviews(revi);
                            console.log(list)
                            console.log(revi)
                        }).catch(err => {
                        console.log(err)
                    })
                })
                .catch((err) => console.log(err));
        } else if (props.which == 2) {
            axios
                .post(
                    "https://localhost:5001/api/TvShowReviews",
                    {
                        "text": newReviewText,
                        "spoiler": newReviewSpoiler,
                        "tvshowid": element.id
                    },
                    {
                        withCredentials: true,
                    }
                ).then((res) => {
                axios.get(`https://localhost:5001/api/tvshows/${props.id}`)
                    .then(res => {
                        console.log(res)
                        const list = res.data.tvShow;
                        const revi = res.data.reviewDto
                        setElement(list);
                        setReviews(revi);
                    }).catch(err => {
                    console.log(err)
                })
            })
                .catch((err) => console.log(err));
        }
    };
    
    
    return (
        <div className="container fade-me">
            <div className="main-body">
                <nav
                    aria-label="breadcrumb"
                    className="main-breadcrumb"

                >
                    <ol className="breadcrumb rad" style={{ backgroundColor: "#191919" }}>
                        <h1 style={{ marginLeft: "20px" }}>{element? element.title : null}</h1>
                    </ol>
                </nav>

                <div className="row gutters-sm rad" >
                    <div className="col-md-4 mb-3 rad">
                        <div className="card rad" style={{ backgroundColor: "#191919" }}>
                            <div className="card-body rad" style={{ backgroundColor: "#191919" }}>
                                <div className="d-flex flex-column align-items-center text-center">
                                    {element? <img src={element.poster} className="rad" height="450px"/> : null}
                                    <div className="mt-3">
                                        {/*<h4>{props.user.name}</h4>*/}
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div className="col-md-8 rad">
                        <div className="card mb-3 rad" style={{ backgroundColor: "#191919" }}>
                            <div className="card-body rad" style={{ backgroundColor: "#191919" }}>
                                <div className="row">
                                    <div className="col-sm-4">
                                        <h6 className="mb-0">Title</h6>
                                    </div>
                                    <div className="col-sm-8 text-secondary">
                                        {element? element.title : null}
                                    </div>
                                </div>
                                <hr />
                                <div className="row">
                                    <div className="col-sm-4">
                                        <h6 className="mb-0">Date</h6>
                                    </div>
                                    <div className="col-sm-8 text-secondary">
                                        {element? element.date : null}
                                    </div>
                                </div>
                                <hr />
                                <div className="row">
                                    <div className="col-sm-4">
                                        <h6 className="mb-0">Summary</h6>
                                    </div>
                                    <div className="col-sm-8 text-secondary">
                                        {element? element.summary : null}
                                    </div>
                                </div>
                                <hr />
                                <div className="row">
                                    <div className="col-sm-4">
                                        <h6 className="mb-0">Rating</h6>
                                    </div>
                                    <div className="col-sm-8 text-secondary">
                                        {element? element.rating : null}
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div className="col-md-12 rad">
                        <div className="card mb-3 rad" style={{ backgroundColor: "#191919" }}>
                            <div className="card-body rad" style={{ backgroundColor: "#191919" }}>
                                
                                <div className="row">
                                    <h1 style={{ marginLeft: "20px" }}>The Reviews</h1>
                                </div>
                                <hr style={{backgroundColor: "#363636"}}/>
                                <div className="row">
                                    <div className="col-sm-2">
                                        <h6 className="mb-0">Write Your Reviwe</h6>
                                    </div>
                                    <form onSubmit={submit} className="col-md-10">
                                        <textarea className="col-md-7 rad" style={{backgroundColor: "#343434", color: "White"}} onChange={(e) => setNewReviewText(e.target.value)}/>
                                        
                                        <input type="checkbox" id="spoilers" name="spoilers" className="col-sm-1" value="Bike" onChange={(e) => setNewReviewSpoiler(!newReviewSpoiler)}/>
                                        <label htmlFor="spoilers" className="col-sm-2" >Spoilers</label>
                                        <input type="submit" name="submit" value="submit" className="col-sm-2 submit"/>
                                    </form>
                                </div>
                                <hr style={{backgroundColor: "#363636"}}/>
                                {reviews.length > 0? reviews.map(review => {
                                   return <div>
                                        <div className="row">
                                                <h6 className="col-sm-2">{review.userName}</h6>
                                                <h6 className="col-md-8">{review.text}</h6>
                                                <h6 className="col-md-2" style={{color: "red"}}>{review.spoiler? "Spoilers": null}</h6>
                                            </div>
                                       <hr style={{backgroundColor: "#363636"}}/>
                                   </div>
                                }) : null}
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    );
}

export default Info;