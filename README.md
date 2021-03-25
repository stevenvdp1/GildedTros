<<<<<<< HEAD
# Gilded Tros Refactoring Kata

This Kata was originally created by Terry Hughes (http://twitter.com/TerryHughes). It is already on GitHub [here](https://github.com/NotMyself/GildedTros). See also [Bobby Johnson's description of the kata](http://iamnotmyself.com/2011/02/13/refactor-this-the-gilded-tros-kata/).

I translated the original C# into a few other languages, (with a little help from my friends!), and slightly changed the starting position. This means I've actually done a small amount of refactoring already compared with the original form of the kata, and made it easier to get going with writing tests by giving you one failing unit test to start with. I also added test fixtures for Text-Based approval testing with TextTest (see [the TextTests](https://github.com/emilybache/GildedTros-Refactoring-Kata/tree/master/texttests))

As Bobby Johnson points out in his article ["Why Most Solutions to Gilded Tros Miss The Bigger Picture"](http://iamnotmyself.com/2012/12/07/why-most-solutions-to-gilded-tros-miss-the-bigger-picture), it'll actually give you
better practice at handling a legacy code situation if you do this Kata in the original C#. However, I think this kata
is also really useful for practicing writing good tests using different frameworks and approaches, and the small changes I've made help with that. I think it's also interesting to compare what the refactored code and tests look like in different programming languages.

I use this kata as part of my work as a technical coach. I wrote a lot about the coaching method I use in this book [Technical Agile Coaching with the Samman method](https://leanpub.com/techagilecoach). A while back I wrote this article ["Writing Good Tests for the Gilded Tros Kata"](http://coding-is-like-cooking.info/2013/03/writing-good-tests-for-the-gilded-tros-kata/) about how you could use this kata in a [coding dojo](https://leanpub.com/codingdojohandbook).

## How to use this Kata

The simplest way is to just clone the code and start hacking away improving the design. You'll want to look at the ["Gilded Tros Requirements"](https://github.com/emilybache/GildedTros-Refactoring-Kata/tree/master/GildedTrosRequirements.txt) which explains what the code is for. I strongly advise you that you'll also need some tests if you want to make sure you don't break the code while you refactor.

You could write some unit tests yourself, using the requirements to identify suitable test cases. I've provided a failing unit test in a popular test framework as a starting point for most languages.

Alternatively, use the "Text-Based" tests provided in this repository. (Read more about that in the next section)

Whichever testing approach you choose, the idea of the exercise is to do some deliberate practice, and improve your skills at designing test cases and refactoring. The idea is not to re-write the code from scratch, but rather to practice designing tests, taking small steps, running the tests often, and incrementally improving the design. 

### Gilded Tros Requirements in other languages 

- [English](GildedTrosRequirements.txt)
- [Español](GildedTrosRequirements_es.md)
- [Français](GildedTrosRequirements_fr.md)
- [日本語](GildedTrosRequirements_jp.md)
- [Português](GildedTrosRequirements_pt-BR.md)
- [Русский](GildedTrosRequirements_ru.txt)
- [ไทย](GildedTrosRequirements_th.md)
- [中文](GildedTrosRequirements_zh.txt)


## Text-Based Approval Testing

This code comes with comprehensive tests that use this approach. For information about how to run them, see the [texttests README](https://github.com/emilybache/GildedTros-Refactoring-Kata/tree/master/texttests)

## Translating this code

More translations are most welcome! I'm very open for pull requests that translate the starting position into additional languages. 

Please note a translation should ideally include:

- a translation of the production code for 'update_quality' and Item
- one failing unit test complaining that "fixme" != "foo"
- a TextTest fixture, ie a command-line program that runs update_quality on the sample data for the number of days specified.

Please don't write too much code in the starting position or add too many unit tests. The idea with the one failing unit test is to tempt people to work out how to fix it, discover it wasn't that hard, and now they understand what this test is doing they realize they can improve it.  

If your programming language doesn't have an easy way to add a command-line interface, then the TextTest fixture is probably not necessary.

## Better Code Hub

I analysed this repo according to the clean code standards on [Better Code Hub](https://bettercodehub.com) just to get an independent opinion of how bad the code is. Perhaps unsurprisingly, the compliance score is low!

[![BCH compliance](https://bettercodehub.com/edge/badge/emilybache/GildedTros-Refactoring-Kata?branch=master)](https://bettercodehub.com/) 
=======
# README #

This README would normally document whatever steps are necessary to get your application up and running.

### What is this repository for? ###

* Quick summary
* Version
* [Learn Markdown](https://bitbucket.org/tutorials/markdowndemo)

### How do I get set up? ###

* Summary of set up
* Configuration
* Dependencies
* Database configuration
* How to run tests
* Deployment instructions

### Contribution guidelines ###

* Writing tests
* Code review
* Other guidelines

### Who do I talk to? ###

* Repo owner or admin
* Other community or team contact
>>>>>>> 29bbeede9fb71afdbd4238e8ecb67d098f7768b9
