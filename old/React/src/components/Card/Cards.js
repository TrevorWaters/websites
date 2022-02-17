import React from 'react';
import CardItem from './CardItem';
import './Cards.css';
import cardimg from '../../images/img-9.jpg';
import cardimg1 from '../../images/img-8.jpg';

function Cards() {
    return (
        <div className='cards'>
            <h1>CHECK OUT INFO</h1>
            <div className='cards-container'>
                <div className='cards-wrapper'>
                    <ul className="cards-items">
                        <CardItem
                            src={cardimg}
                            text='Explore EXAMPLES'
                            label='MORE EADADED'
                            path='/other'
                        />
                        <CardItem
                            src={cardimg1}
                            text='DADADA'
                            label='MORE'
                            path='/music'
                        />
                    </ul>
                </div>
            </div>

            
        </div>
    )
}

export default Cards
