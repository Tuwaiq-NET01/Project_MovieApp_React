import React from 'react'

export default function Search(props) {
    return (
        <div className='container'>
            <h1 className='display-4'>Search Results for: {props.target}</h1>
        </div>
    )
}
