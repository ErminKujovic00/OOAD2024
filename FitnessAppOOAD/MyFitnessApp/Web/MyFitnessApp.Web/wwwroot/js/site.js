// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

using System;
using System.Collections.Generic;

public partial class YourPage : System.Web.UI.Page
{
    protected string RandomSentence { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {
            List < string > sentences = new List < string >
            {
                "Every rep gets you closer to your goals.",
                "Your body can stand almost anything; it's your mind you have to convince.",
                "Sweat is just fat crying.",
                "The pain you feel today will be the strength you feel tomorrow.",
                "Push yourself because no one else is going to do it for you.",
                "The only bad workout is the one that didn’t happen.",
                "Strive for progress, not perfection.",
                "Believe in yourself and all that you are.",
                "Your only limit is you.",
                "Success starts with self-discipline.",
                "Great things never come from comfort zones.",
                "You don’t have to be extreme, just consistent.",
                "It’s not about having time; it’s about making time.",
                "Small daily improvements are the key to staggering long-term results.",
                "Do something today that your future self will thank you for.",
                "The body achieves what the mind believes.",
                "No matter how slow you go, you are still lapping everybody on the couch.",
                "Train insane or remain the same.",
                "Fitness is not about being better than someone else. It’s about being better than you used to be.",
                "Don’t stop until you’re proud.",
                "Wake up with determination; go to bed with satisfaction.",
                "What seems impossible today will one day become your warm-up.",
                "A one-hour workout is 4% of your day. No excuses.",
                "You are stronger than you think.",
                "Sweat now, shine later.",
                "You don’t get what you wish for; you get what you work for.",
                "When you feel like quitting, think about why you started.",
                "Hard work beats talent when talent doesn’t work hard.",
                "The pain you feel today will be the strength you feel tomorrow.",
                "You are one workout away from a good mood.",
                "Fitness is like a relationship; you can’t cheat and expect it to work.",
                "Focus on progress, not perfection.",
                "The harder you work for something, the greater you’ll feel when you achieve it.",
                "Fitness is not about being better than someone else; it’s about being better than you used to be.",
                "Don’t limit your challenges; challenge your limits.",
                "Make your body the sexiest outfit you own.",
                "Push harder than yesterday if you want a different tomorrow.",
                "Strength doesn’t come from what you can do. It comes from overcoming the things you once thought you couldn’t.",
                "You didn’t come this far to only come this far.",
                "Sweat is magic. Cover yourself in it daily to grant your wishes.",
                "Your body hears everything your mind says. Stay positive.",
                "The difference between try and triumph is just a little umph!",
                "Discipline is choosing between what you want now and what you want most.",
                "Motivation gets you started; habit keeps you going.",
                "Fitness is not a destination; it is a way of life.",
                "A champion is someone who gets up when they can’t.",
                "Your mind is a powerful thing. When you fill it with positive thoughts, your life will start to change.",
                "The pain you feel today will be the strength you feel tomorrow.",
                "It always seems impossible until it’s done.",
                "Exercise not only changes your body, it changes your mind, your attitude, and your mood."
            };

            Random rand = new Random();
            int index = rand.Next(sentences.Count);
            RandomSentence = sentences[index];
        }
    }
}



/*05.08.2021*/
/*Bootstrap 4 Swing Counter with font awesome*/
/*https://bbbootstrap.com/snippets/swing-counter-font-awesome-73778739*/
$(document).ready(function () {

    $('.counter').each(function () {
        $(this).prop('Counter', 0).animate({
            Counter: $(this).text()
        }, {
            duration: 4000,
            easing: 'swing',
            step: function (now) {
                $(this).text(Math.ceil(now));
            }
        });
    });
});