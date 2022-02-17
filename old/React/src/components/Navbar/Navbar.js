import React, {useState, useEffect} from 'react'
import { Link } from 'react-router-dom'
import { Button } from '../Button/Button';
import './Navbar.css';

function Navbar() {
    const [click, setClick] = useState(false);
    const [button, setButton] = useState(true);

    const handleClick = () => setClick(!click);
    const closeMobileMenu = () => setClick(false);

    const showButton = () => {
        if(window.innerWidth <= 960) {
            setButton(false);
        } else {
            setButton(true);        
        }
    };

    useEffect(() => {
        showButton()
    }, []);


    window.addEventListener('resize', showButton);



    return (
        <>
        <nav className="navbar">
            <div className="navbar-container">
                
                <div className='menu-icon' onClick={handleClick}>
                    <i className={click ? 'fas fa-times' : 'fas fa-bars'} ></i>
                </div>
            
            <ul className={click ? 'nav-menu active' : 'nav-menu'}>
                <li className='nav-item'>
                    <Link to='/' className='nav-links' onClick={closeMobileMenu}>
                        Home
                    </Link>
                </li>
                <li className='nav-item'>
                    <Link to='/blog' className='nav-links' onClick={closeMobileMenu}>
                        Blog
                    </Link>
                </li>
                <li className='nav-item'>
                    <Link to='/music' className='nav-links' onClick={closeMobileMenu}>
                        Music
                    </Link>
                </li>
                <li className='nav-item'>
                    <Link to='/other' className='nav-links' onClick={closeMobileMenu}>
                        Other
                    </Link>
                </li>
                    </ul>
            <section className="nav-social-media">
                <div className='nav-social-media-wrap'>
                    <div className='nav-social-icons'>
                        <Link
                        className='nav-social-icon-link facebook'
                        to='/'
                        target='_blank'
                        aria-label='Facebook'
                        >
                        <i className='fab fa-facebook-f' />
                        </Link>
                        <Link
                        className='nav-social-icon-link instagram'
                        to='/'
                        target='_blank'
                        aria-label='Instagram'
                        >
                        <i className='fab fa-instagram' />
                        </Link>
                        <Link
                        className='nav-social-icon-link youtube'
                        to='/'
                        target='_blank'
                        aria-label='Youtube'
                        >
                        <i className='fab fa-youtube' />
                        </Link>
                        <Link
                        className='nav-social-icon-link twitter'
                        to='/'
                        target='_blank'
                        aria-label='Twitter'
                        >
                        <i className='fab fa-twitter' />
                        </Link>
                    </div>
                    </div>
            </section>
        </div>              
        </nav>
        </>
    )
}

export default Navbar
