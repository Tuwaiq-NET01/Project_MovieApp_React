import React from 'react'
import { useSelector, useDispatch } from 'react-redux'
import { removeFavorite } from '../action';

export default function Favorite() {

    const favoriteList = useSelector(state => state.favoriteList)
    const dispatch = useDispatch()
    return (
        <div className='container'>
            <h1 className='display-4'>FAVORITES PAGE </h1>
            {favoriteList.map((value, index) => {
                return (
                    <div>
                        <h1>{value.title}</h1>
                        <button onClick={() => dispatch(removeFavorite(index))}>Unfavorite</button>
                    </div>
                )
            })}
        </div>
    )
}
