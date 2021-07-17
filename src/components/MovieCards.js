import React, { Component } from "react";
import Card from "react-bootstrap/Card";
import Button from "react-bootstrap/Button";
import { Link} from "react-router-dom";
import { initReactI18next } from 'react-i18next'
import languageDetector from 'i18next-browser-languagedetector'
import { useTranslation, Trans } from 'react-i18next'
import { useDispatch } from 'react-redux';
import { removeFavorite } from '../action';
import { addFavorite } from '../action';
import i18n from 'i18next'

i18n.use(initReactI18next).use(languageDetector).init({
    resources: {
         en: {
             
             translation: {
                Favorite:"Favorite"
             }
         },
         ar: {
             
             translation: {
                Favorite:"مفضلة"
             }
         }
     }
  })
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

                <Link to={`/Project_MovieApp_React/movies/${props.id}`}> 
                    {props.Title}
                </Link>

            </Card.Title>
            {props.favMode ? <button className='btn btn-danger' onClick={() => dispatch(removeFavorite(props.index))}>Unfavorite</button> : <Button variant="warning" onClick={() => dispatch(addFavorite(props.Movie))}> <Trans i18nKey="Favorite">
            Favorite
        </Trans> </Button> }
            </Card.Body>
            </Card>
            </center>
         </div>
        )
    }
