// Tuodaan kaboom-kirjasto
import kaboom from 'kaboom';
// Alustetaan kaboom
kaboom({
    global: true,
    fullscreen: true,
    scale: 1,
    debug: true,
});
loadRoot();
loadSprite('bird', '/Users/jyrilindroos/source/repos/Ohke/kaboom/src/sprites/bird.png');
loadSprite('link-going-right', 'https://i.imgur.com/yZIb802.png');

scene("game", () =>{

});
