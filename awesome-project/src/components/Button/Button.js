import React from 'react';
import './Button.css';
import { Link } from 'react-router-dom';

const STYLES = ['btn--primary', 'btn--outline']

const SIZES = ['btn--medium', 'btn--large'];
    
export const Button = ({
    children, 
    type, 
    buttonStyle, 
    buttonSize,
    onClick
}) => {
    const checkButtonStyle = STYLES.includes(buttonStyle)
        ? buttonStyle
        : STYLES[0];

    const checkButtonSize = SIZES.includes(buttonSize)
        ? buttonSize
        : SIZES[0];


    onClick = function DoSomething() 
        {
        var choices = [
            'https://www.instagram.com/ryespittinfye',
            'https://www.facebook.com/riley.waters.77'];
        var item = choices[Math.floor(Math.random() * choices.length)];
    
        window.open(item);
    }
    return (
        <Link to='/' className='btn-mobile'>
            <button 
                className={`btn ${checkButtonStyle} ${checkButtonSize}`}
                type={type}
                onClick ={onClick}
            >
                {children}
            </button>
        </Link>
    )
};
