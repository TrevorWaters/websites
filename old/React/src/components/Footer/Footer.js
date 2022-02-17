import React from 'react';
import { Button } from '../Button/Button';
import { Link } from 'react-router-dom';
import './Footer.css';

function Footer() {
    return (
        <div className='footer-container'>
            <section className="footer-subscription">
                <p className="footer-subscription-heading">
                    Join the List and I'll figure out how to get back to you
                </p>
                <p className="footer-subscription-text">
                    You are already unsubscribed b/c I don't have this hooked up to anything.
                </p>
                <form className='input-areas'>
                    <input
                        className='footer-input'
                        type='email'
                        name='email'
                        placeholder='Email'
                    />
                    <Button buttonStyle='button--outline'>Subscribe</Button>
                        
                </form>
            </section>
            <div className="footer-links">
                <div className="footer-link-wrapper">
                    <div className="footer-link-items">
                        <h2>About Me</h2>
                        <Link to='/other'>Stuff</Link>
                        <Link to='/'>Test</Link>
                        <Link to='/'>More Words</Link>
                    </div>
                    <div className="footer-link-items">
                        <h2>About Me</h2>
                        <Link to='/other'>Stuff</Link>
                        <Link to='/'>Test</Link>
                        <Link to='/'>More Words</Link>
                    </div>
                    <div className="footer-link-items">
                        <h2>About Me</h2>
                        <Link to='/'>Stuff</Link>
                        <Link to='/'>Test</Link>
                        <Link to='/'>More Words</Link>
                    </div>
                </div>
                <div className="footer-link-wrapper">
                    <div className="footer-link-items">
                        <h2>About Me</h2>
                        <Link to='/'>Stuff</Link>
                        <Link to='/'>Test</Link>
                        <Link to='/'>More Words</Link>
                    </div>
                    <div className="footer-link-items">
                        <h2>About Me</h2>
                        <Link to='/'>Stuff</Link>
                        <Link to='/'>Test</Link>
                        <Link to='/'>More Words</Link>
                    </div>
                    <div className="footer-link-items">
                        <h2>About Me</h2>
                        <Link to='/'>Stuff</Link>
                        <Link to='/'>Test</Link>
                        <Link to='/'>More Words</Link>
                    </div>
                </div>
            </div>
            <section className='social-media'>
        <div className='social-media-wrap'>
          <div className='footer-logo'>
            <Link to='/' className='social-logo'>
              TRVL
              <i className='fab fa-typo3' />
            </Link>
          </div>
          <small className='website-rights'>TRVL © 2020</small>
          <div className='social-icons'>
            <Link
              className='social-icon-link facebook'
              to='/'
              target='_blank'
              aria-label='Facebook'
            >
              <i class='fab fa-facebook-f' />
            </Link>
            <Link
              className='social-icon-link instagram'
              to='/'
              target='_blank'
              aria-label='Instagram'
            >
              <i className='fab fa-instagram' />
            </Link>
            <Link
              className='social-icon-link youtube'
              to='/'
              target='_blank'
              aria-label='Youtube'
            >
              <i className='fab fa-youtube' />
            </Link>
            <Link
              className='social-icon-link twitter'
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
  );
}

export default Footer
