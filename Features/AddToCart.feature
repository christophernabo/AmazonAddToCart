Feature: Add an item to Cart

  As an unregistered user
  He/She wants to search for a specific item
  So that he/she can add it to my cart and validate the details
  
  Scenario: Add TP-Link N450 WiFi Router to cart
    Given User navigate to the Amazon website
    When User searches for "TP-Link N450 WiFi Router - Wireless Internet Router for Home (TL-WR940N)"
    And User adds the item to my cart
    And User navigates to the cart
    Then User can validate that the correct item and amount are displayed for "TP-Link N450 WiFi Router - Wireless Internet Router for Home (TL-WR940N)"