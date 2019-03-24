Feature: WeatherAPI
	In order to have a happy holiday
	As a holiday maker
	I want to be able to receive weather forecast

@WeatherAPI-FunctionalTests
Scenario Outline: A happy holiday maker
	Given I like to holiday in <city>
	And I only like to holiday on <day>
	When I look up the weather forecast
	Then I receive the weather forecast
	And the temperature is warmer than <minimum temperature> degrees
	
	Examples:
    | city      | day      | minimum temperature |
    | Sydney,AU | Thursday | 10                  |

Scenario: WeatherAPI rejects the request that does not provide API Key
	Given I like to holiday
	When I look up the weather forecast without providing API Key
	Then I receive Unauthorised error

Scenario: WeatherAPI returns a json type response when Response mode is set to json
	Given I like to holiday
	When I set response type as json
	And I look up the weather forecast	
	Then the response returned is in json format

Scenario: WeatherAPI returns a XML type response when Response mode is set to xml
	Given I like to holiday 
	When I set response type as xml
	And I look up the weather forecast 
	Then the response returned is in XML format

Scenario: WeatherAPI's default Response mode is JSON
	Given I like to holiday 
	When I do not set response type
	And I look up the weather forecast
	Then the response returned is in JSON format

	 

