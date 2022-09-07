# Process Documentation

## 09.07.22 - Initial Thinking

### Project / sketch goals
* At a most fundamental layer, exploration of using Wwise within Unity for sound/music control
* Deeper than this, though is: **how can we use sound to communicate game-state in a more engaging way?**
* Make a "fun" thing
 
### An idea
Roll and writes are an enjoyable game-style, but often you are not entirely sure if you're doing "well" as you are playing. 
Smaller examples like [Yahtzee](https://en.wikipedia.org/wiki/Yahtzee) and [Qwixx](https://gamewright.com/product/Qwixx) make it easier to follow (especially with how the scoring sheets are laid out), but more robust examples could benefit from some added illumination[<sup>1</sup>](#####1).
Is this what is stopping more complex board-based roll and writes ([Dinosaur Island: Rawr 'N Write](https://pandasaurusgames.com/products/dinosaur-island-rawr-write) comes to mind<sup>[2](######2)</sup> ) from being more widely-adopted on digital platforms?

In particular, making a game similar to David King's wonderful [Tiny Islands](https://dr-d-king.itch.io/tiny-islands) feels like an interesting space to be exploring these ideas.

With these things in mind...

### Brainstorming

Immediately the idea of laying out pizza toppings (rather than island-town attractions) seems fun. 
At lunch with the 'lilionaires<sup>TM</sup> we start brainstorming what kind of goals/restrictions you could implement.

<img src="images/initialBrainstorm.jpg" width="500" />

#### Compelling Ideas:
* certain foods don't want to be next to others (i.e pineapple <sup>[3](#####3)</sup> )
* trying to separate out half/quarter pies for different goals (meat lovers, veggie, dairy-free?)
* spicy/sweet stuff as bonuses
* rotating through quadrants for placement
* a "conveyer-belt" style delivery of ingredients for immediate placement
* the ability to slice after the fact? (more complicated and possibly harder to implement the desired audio, but an interesting game idea)

### Onward!

So Purrrfect Pizzas<sup>[4](#####4)</sup> is born, a digital roll and write where you try to make perfect pizzas to please your picky patrons. 
It  practically makes itself! Except that it doesn't. That's what the next month is for. First step: quick and dirty paper prototypes to get some very rough ideas of the overall loop.

### Notes
<sub>

##### 1 Question: if Yahtzee is so named because it was invented on a boat, then why isn't it Yachtzee? They've taken the C out of a game intended for a yacht (all puns intended)
##### 2 Oddly enough, Dinosaur Island: Rawr 'N Write appears to have a [digital companion app](https://apps.apple.com/us/app/rawr-n-write/id1587414158) to help in the tedious chore of score-keeping, so maybe the argument is moot
##### 3 Calm down
##### 4 I mean, c'mon

</sub>