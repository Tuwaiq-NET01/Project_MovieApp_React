import React, { Component } from "react";
import Card from "react-bootstrap/Card";
import Button from "react-bootstrap/Button";
import { useDispatch } from 'react-redux';
import { addFavorite } from '../action';
export default function MovieCards (props)
{        
    const dispatch = useDispatch(); 
    return (
            
         <div className="Movie" >
             <center>
            <Card style={{ width: '16rem' }}>
            <center>{props.Poster} </center>
            <Card.Body>
            <Card.Title>

                {/* <Link to={`/movies/${props.Title}`}> */}
                    {props.Title}
                {/* </Link> */}

            </Card.Title>
            <Card.Text>{props.Year}  </Card.Text>
            <Card.Text>{props.imdbID}  </Card.Text>
            <Card.Text>{props.Type}  </Card.Text>
            <Button variant="danger" onClick={() => dispatch(addFavorite(props.Movie))}>Favorite</Button>
            <div className="space1"></div>
            <Button variant="danger">Delete movie</Button>


            </Card.Body>
            </Card>
            </center>
         </div>
        )
    }
