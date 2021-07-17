import React, { Component } from 'react'

export default class Layout extends Component {
    render() {
        const body = document.getElementsByTagName('body')[0];
        body.style.backgroundColor = 'rgb(9, 57, 102)';
        return (
            <div>
                {this.props.children}
            </div>
        )
    }
}
