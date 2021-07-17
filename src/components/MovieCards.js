import React, { Component } from "react";
import Card from "react-bootstrap/Card";
import Button from "react-bootstrap/Button";
import { Link, BrowserRouter as Router , Switch, Route} from "react-router-dom";

import { useDispatch } from 'react-redux';
import { addFavorite } from '../action';
export default function MovieCards (props)
{        
    const dispatch = useDispatch(); 
    return (
            
         <div className="Movie" >
             <center>
            <Card style={{ width: '20rem' }}>
            <center> <img src = {"https://image.tmdb.org/t/p/w500"+props.Poster} alt='poster'/></center>

            <Card.Body>
            <Card.Title>

                <Link to={`/movies/${props.id}`}> 
                    {props.Title}
                </Link>

            </Card.Title>
            <Button variant="danger" onClick={() => dispatch(addFavorite(props.Movie))}>Favorite</Button>
            </Card.Body>
            </Card>
            </center>
         </div>
        )
    }
