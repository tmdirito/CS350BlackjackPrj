# Blackjack Game

This repository contains a C# WinForms application that implements a blackjack game.

## Features

*   **Core Gameplay:**
    *   Standard blackjack rules
    *   Dealing cards
    *   Calculating hand values (including Aces)
    *   Player actions (Hit, Stand)
    *   Dealer logic
    *   Determining the winner
*   **Visuals:**
    *   Card images displayed in PictureBoxes
    *   Background image for a virtual blackjack table
    *   Custom button styles
*   **Additional Features:**
    *   Dynamic PictureBox creation for hit cards
    *   FlowLayoutPanels for card arrangement
    *   Two player mode implemented

## Getting Started

1.  **Prerequisites:**
    *   Visual Studio 2022 (or later) with .NET MAUI workload installed
    *   .NET SDK
2.  **Clone the repository:**
    *   https://github.com/tmdirito/CS350BlackjackPrj.git

## How to Play
1. Select single or two player mode upon program launch.
2. Toggle between player 1 and player 2 bets using buttons to place a bet before selecting "DEAL" to deal the initial hand.
3. Select "HIT" to take another card.
4. Select "STAND" to keep your current hand.
   * If two player, steps 3-4 repeat for player 2.
5. The dealer will automatically play their hand, a winner will be determined, and money will be awarded respective to outcome and bets placed.

## Future implementation
1. Smoother graphics.
2. Higher level blackjack logic (i.e splitting, doubling down, etc.)
3. Framework adjustments to allow for the app to be run on IOS/Android.

