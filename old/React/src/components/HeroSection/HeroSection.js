import React from 'react';
import '../../App.css';
import { Button } from '../Button/Button';
import './HeroSection.css';

import montage from '../../videos/montage.gif';



function HeroSection() {
    return (
        <div className='hero-container'>
            <img src={montage} autoPlay loop muted />
            <h1>TEST NAME@#$</h1>
            <p>Watch me rap</p>
            <div className='hero-btns'>
                <Button
                className='btns'
                buttonStyle='btn--outline'
                    buttonSize='btn--large'
                >
                    FOLLOW ON SOMETHING
                </Button>
                <Button
                className='btns'
                buttonStyle='btn--primary'
                buttonSize='btn--large'
                >
                    CHECK IT <i className='fab fa-spotify' />
                </Button>
            </div>
            
        </div>
    )
}

export default HeroSection
