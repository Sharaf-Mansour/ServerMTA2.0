using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Components;

namespace ServerMTA.Model
{
    public class ExamAIData
    {

        public static List<Exam> Exams100Static => new()
        {
            new(1, new()
            {
                new(1, @"increased sales"),
                new(2, @"a reduced workload for the customer service agents", true),
                new(3, @"improved product reliability"),
            }, @"A company employs a team of customer service agents to provide telephone and email support to customers.
The company develops a webchat bot to provide automated answers to common customer queries.
Which business benefit should the company expect as a result of creating the webchat bot solution?
"),
            new(2, new()
            {
                new(1, @"Use features for training and labels for evaluation."),
                new(2, @" Randomly split the data into rows for training and rows for evaluation.", true),
                new(3, @"Use labels for training and features for evaluation."),
                new(4, @"Randomly split the data into columns for training and columns for evaluation."),
            }, @"For a machine learning progress, how should you split data for training and evaluation?
"),
            new(3, new()
            {
                new(1, @"Set Validation type to Auto."),
                new(2, @"Enable Explain best model.", true),
                new(3, @"Set Primary metric to accuracy."),
                new(4, @"Set Max concurrent iterations to 0."),
            }, @"You build a machine learning model by using the automated machine learning user interface (UI).
You need to ensure that the model meets the Microsoft transparency principle for responsible AI.
What should you do?"),
            new(4, new()
            {
                new(1, @"inclusiveness."),
                new(2, @"privacy and security"),
                new(3, @"reliability and safety", true),
                new(4, @"transparency"),
            }, @"The handling of unusual or missing values provided to an AI system is a consideration
for the microsoft _BLANK_ principle for resposible AI."),
            new(5, new()
            {
                new(1, @"fairness"),
                new(2, @"inclusiveness", true),
                new(3, @"reliability and safety"),
                new(4, @"accountability"),
            }, @"You are designing an AI system that empowers everyone, including people who have hearing, visual, and other impairments.
This is an example of which Microsoft guiding principle for responsible AI?"),
            new(6, new()
            {
                new(1, @"inclusiveness"),
                new(2, @"accountability"),
                new(3, @"reliability and safety", true),
                new(4, @"fairness"),
            }, @"Wen developing an AI system for self-driving cars, the Microsoft _Blank_ principle
for responsible AI shloud be applied to ensure consistent operation of the
system during unexpeceted circumstances."),
            new(7, new()
            {
                new(1, @"Form Recognizer", true),
                new(2, @"Text Analytics"),
                new(3, @"Ink Recognizer"),
                new(4, @"Custom Vision"),
            }, @"Which service should you use to extract text, key/value pairs, and table data automatically 
from scanned documents?"),
            new(8, new()
            {
                new(1, @"Custom Vision"),
                new(2, @"From Recognizer", true),
                new(3, @"Ink Recognizer"),
                new(4, @"Text Analytics"),
            }, @"The ability to extract subtotals and totals from a receipt is a capability of the _Blank_ service"),
            new(9, new()
            {
                new(1, @"the model name", true),
                new(2, @"the training endpoint"),
                new(3, @"the authentication key"),
                new(4, @"the REST endpoint", true),
            }, @"You use Azure Machine Learning designer to publish an inference pipeline.
Which two parameters should you use to consume the pipeline? Each correct answer presents part of the solution.
NOTE: Each correct selection is worth one point.", ControlType.CheackBox),
            new(10, new()
            {
                new(1, @"a local web service"),
                new(2, @"Azure Container Instances"),
                new(3, @"Azure Kubernetes Service (AKS)", true),
                new(4, @"Azure Machine Learning compute"),
            }, @"From Azure Machine Learning designer, to deploy a real-time inference pipeline as a service for
others to consume, You must deploy the model to _Blank_"),
            new(11, new()
            {
                new(1, @"classification"),
                new(2, @"clustering"),
                new(3, @"regression", true),
            }, @"Predicting how many hours of overtime a delivery person will work based on
the number of order received is an example of _Blank_"),
            new(12, new()
            {
                new(1, @"true positive rate", true),
                new(2, @"mean absolute error (MAE)"),
                new(3, @"coefficient of determination (R2)"),
                new(4, @"root mean squared error (RMSE)"),
            }, @"Which metric can you use to evaluate a classification model?"),
            new(13, new()
            {
                new(1, @"dataset", true),
                new(2, @"compute"),
                new(3, @"pipeline"),
                new(4, @"module", true),
            }, @"Which two components can you drag onto a canvas in Azure Machine Learning designer? Each correct answer presents a complete solution.
NOTE: Each correct selection is worth one point."),
            new(14, new()
            {
                new(1, @"Select Columns in Dataset"),
                new(2, @"Add Rows"),
                new(3, @"Split Data", true),
                new(4, @"Join Data"),
            }, @"You need to create a training dataset and validation dataset from an existing dataset.
Which module in the Azure Machine Learning designer should you use?"),
            new(15, new()
            {
                new(1, @"Dependant variables"),
                new(2, @"features", true),
                new(3, @"identifiers"),
                new(4, @"labels"),
            }, @"Data Values that influence the prediction of a model are called _Blank_"),
            new(16, new()
            {
                new(1, @"classification"),
                new(2, @"regression", true),
                new(3, @"clustering"),
            }, @"Which type of machine learning should you use to predict the number of gift cards that will be sold next month?"),
            new(17, new()
            {
                new(1, @"the number of taxi journeys in the dataset"),
                new(2, @"the trip distance of individual taxi journeys", true),
                new(3, @"the fare of individual taxi journeys"),
                new(4, @"the trip ID of individual taxi journeys"),
            }, @"You have a dataset that contains information about taxi journeys that occurred during a given period.
You need to train a model to predict the fare of a taxi journey.
What should you use as a feature?"),
            new(18, new()
            {
                new(1, @"classification"),
                new(2, @"regression", true),
                new(3, @"clustering"),
            }, @"You need to predict the sea level in meters for the next 10 years.
Which type of machine learning should you use?"),
            new(19, new()
            {
                new(1, @"You should consider creating an element in the class."),
                new(2, @"You should consider creating a constructor in the class", true),
                new(3, @"You should consider creating a customized interface for the class."),
                new(4, @"You should consider developing a common interface for the class."),
            }, @"You are employed as a developer at xyz.com.
You make use of C# and ASP.NET for development purposes.
You have been instructed to create a new class.
The new class must allow for the immediate initialization of its data members every time an object of the class is created.
Which of the following actions should you take?"),
            new(20, new()
            {
                new(1, @"classification", true),
                new(2, @"regression"),
                new(3, @"clustering"),
            }, @"a banking system that predicts whether a loan will be repaid is an example of the _Blank_ type of machine learning"),
            new(21, new()
            {
                new(1, @"semantic segmentation"),
                new(2, @"image classification"),
                new(3, @"object detection"),
                new(4, @"optical character recognition (OCR)", true),
            }, @"You need to develop a mobile app for employees to scan and store their expenses while travelling.
Which type of computer vision should you use?"),
            new(22, new()
            {
                new(1, @"optical character recognition (OCR)"),
                new(2, @"object detection", true),
                new(3, @"image classification"),
                new(4, @"face detection"),
            }, @"You need to determine the location of cars in an image so that you can estimate the distance between the cars.
Which type of computer vision should you use?"),
            new(23, new()
            {
                new(1, @"Computer Vision"),
                new(2, @"Custom Vision", true),
                new(3, @"Form Recognizer"),
                new(4, @"Video Indexer"),
            }, @"You can use the _Blank_ service to train an object detection model by using your own images."),
            new(24, new()
            {
                new(1, @"Train a custom image classification model."),
                new(2, @"Detect faces in an image.", true),
                new(3, @"Recognize handwritten text.", true),
                new(4, @"Translate the text in an image between languages."),
            }, @"What are two tasks that can be performed by using the Computer Vision service? Each correct answer presents a complete solution.
NOTE: Each correct selection is worth one point.", ControlType.CheackBox),
            new(25, new()
            {
                new(1, @"predicting how many cups of coffee a person will drink based on how many hours the person slept the previous night."),
                new(2, @"analyzing the contents of images and grouping images that have similar colors"),
                new(3, @"predicting whether someone uses a bicycle to travel to work based on the distance from home to work", true),
                new(4, @"predicting how many minutes it will take someone to run a race based on past race times"),
            }, @"What is a use case for classification?"),
            new(26, new()
            {
                new(1, @"Predict stock prices."),
                new(2, @"Detect brands in an image.", true),
                new(3, @"Detect the color scheme in an image", true),
                new(4, @"Translate text between languages."),
                new(5, @"Extract key phrases."),
            }, @"What are two tasks that can be performed by using computer vision? Each correct answer presents a complete solution.
NOTE: Each correct selection is worth one point.", ControlType.CheackBox),
            new(27, new()
            {
                new(1, @"anomaly detection"),
                new(2, @"conversational AI"),
                new(3, @"computer vision", true),
                new(4, @"natural language processing"),
            }, @"Your company wants to build a recycling machine for bottles. The recycling machine must automatically identify bottles of the correct shape and reject all other items.
Which type of AI workload should the company use?"),
            new(28, new()
            {
                new(1, @"anomaly detection"),
                new(2, @"semantic segmentation"),
                new(3, @"regression"),
                new(4, @"natural language processing", true),
            }, @"Your website has a chatbot to assist customers.
You need to detect when a customer is upset based on what the customer types in the chatbot.
Which type of AI workload should you use?"),
            new(29, new()
            {
                new(1, @"classify email messages as work-related or personal.", true),
                new(2, @"predict the number of future car rentals"),
                new(3, @"predict which website visitors will make a transaction"),
                new(4, @"stop a process in a factory when extremely high temperatures are registered"),
            }, @"Natural language processing can be used to"),
            new(30, new()
            {
                new(1, @"Translator Text"),
                new(2, @"Text Analytics"),
                new(3, @"Speech"),
                new(4, @"Language Understanding (LUIS)", true),
            }, @"Which AI service can you use to interpret the meaning of a user input such as 'Call me back later?'"),
            new(31, new()
            {
                new(1, @"Translator Text"),
                new(2, @"QnA Maker"),
                new(3, @"Speech"),
                new(4, @"Language Understanding (LUIS)", true),
            }, @"You are developing a chatbot solution in Azure.
Which service should you use to determine a user's intent?"),
            new(32, new()
            {
                new(1, @"Translator Text", true),
                new(2, @"Text Analytics"),
                new(3, @"Speech"),
                new(4, @"Language Understanding (LUIS)"),
            }, @"You need to make the press releases of your company available in a range of languages.
Which service should you use?"),
            new(33, new()
            {
                new(1, @"language detection"),
                new(2, @"sentiment analysis", true),
                new(3, @"key phrase extraction"),
                new(4, @"entity recognition"),
            }, @"You are developing a natural language processing solution in Azure.
The solution will analyze customer reviews and determine how positive or negative each review is.
This is an example of which type of natural language processing workload?"),
            new(34, new()
            {
                new(1, @"entity recognition."),
                new(2, @"key phrase extraction.", true),
                new(3, @"sentiment analysis"),
                new(4, @"language detection"),
            }, @"You are developing a solution that uses the Text Analytics service.
You need to identify the main talking points in a collection of documents.
Which type of natural language processing should you use?"),
            new(35, new()
            {
                new(1, @"a telephone answering service that has a pre-recorder message"),
                new(2, @"a chatbot that provides users with the ability to find answers on a website by themselves", true),
                new(3, @"telephone voice menus to reduce the load on human resources", true),
                new(4, @"a service that creates frequently asked questions (FAQ) documents by crawling public websites"),
            }, @"Which two scenarios are examples of a conversational AI workload? Each correct answer presents a complete solution.
NOTE: Each correct selection is worth one point.", ControlType.CheackBox),
            new(36, new()
            {
                new(1, @"Generate the questions and answers from an existing webpage.", true),
                new(2, @"Use automated machine learning to train a model based on a file that contains the questions."),
                new(3, @"Manually enter the questions and answers.", true),
                new(4, @"Connect the bot to the Cortana channel and ask questions by using Cortana."),
                new(5, @"Import chit-chat content from a predefined data source.", true),
            }, @" You need to provide content for a business chatbot that will help answer simple user queries.
What are three ways to create question and answer text by using QnA Maker? Each correct answer presents a complete solution.
NOTE: Each correct selection is worth one point.", ControlType.CheackBox),
            new(37, new()
            {
                new(1, @"QnA Maker", true),
                new(2, @"Text Analytics"),
                new(3, @"Computer Vision"),
                new(4, @"Language Understanding (LUIS)"),
            }, @"You have a frequently asked questions (FAQ) PDF file.
You need to create a conversational support system based on the FAQ.
Which service should you use?"),
            new(38, new()
            {
                new(1, @"Text Analytics"),
                new(2, @"QnA Maker", true),
                new(3, @"Azure Bot Service", true),
                new(4, @"Translator Text"),
            }, @"You need to reduce the load on telephone operators by implementing a chatbot to answer simple questions with predefined answers.
Which two AI service should you use to achieve the goal? Each correct answer presents part of the solution.
NOTE: Each correct selection is worth one point.", ControlType.CheackBox),
            new(39, new()
            {
                new(1, @"a smart device in the home that responds to questions such as 'What will the weather be like today?'", true),
                new(2, @"a website that uses a knowledge base to interactively respond to users' questions", true),
                new(3, @"assembly line machinery that autonomously inserts headlamps into cars"),
                new(4, @"monitoring the temperature of machinery to turn on a fan when the temperature reaches a specific threshold"),
            }, @"Which two scenarios are examples of a conversational AI workload? Each correct answer presents a complete solution.
NOTE: Each correct selection is worth one point.", ControlType.CheackBox),
            new(40, new()
            {
                new(1, @"Custom Vision"),
                new(2, @"QnA Maker", true),
                new(3, @"Translator Text"),
                new(4, @"Face"),
            }, @"You need to develop a web-based AI solution for a customer support system.
Users must be able to interact with a web app that will guide them to the best resource or answer.
Which service should you use?"),
            new(41, new()
            {
                new(1, @"QnA Maker", true),
                new(2, @"Language Understanding (LUIS)"),
                new(3, @"Text Analytics"),
                new(4, @"Speech"),
            }, @"Which AI service should you use to create a bot from a frequently asked questions (FAQ) document?"),
            new(42, new()
            {
                new(1, @"anomaly dectection"),
                new(2, @"computer vision"),
                new(3, @"conversaional AI", true),
                new(4, @"forecasting"),
            }, @"The interactive answering of questions entered by user as part of an application is an example of _BLANK_"),
            new(43, new()
            {
                new(1, @"Ensure that all visuals have an associated text that can be read by a screen reader."),
                new(2, @"Enable autoscaling to ensure that a service scales based on demand."),
                new(3, @"Provide documentation to help developers debug code.", true),
                new(4, @"Ensure that a training dataset is representative of the population."),
            }, @"You are building an AI system.
Which task should you include to ensure that the service meets the Microsoft transparency principle for responsible AI?"),
            new(44, new()
            {
                new(1, @"accountability"),
                new(2, @"fairness"),
                new(3, @"inclusiveness", true),
                new(4, @"privacy and security"),
            }, @"Your company is exploring the use of voice recognition technologies in its smart home devices.
The company wants to identify any barriers that might unintentionally leave out specific user groups.
This an example of which Microsoft guiding principle for responsible AI?"),
            new(45, new()
            {
                new(1, @"knowledgeability"),
                new(2, @"decisiveness"),
                new(3, @"inclusiveness", true),
                new(4, @"fairness", true),
                new(5, @"opinionatedness"),
                new(6, @"reliability and safety", true),
            }, @"What are three Microsoft guiding principles for responsible AI? Each correct answer presents a complete solution.
NOTE: Each correct selection is worth one point.", ControlType.CheackBox),
            new(46, new()
            {
                new(1, @"the Verify operation in the Face service"),
                new(2, @"the Detect operation in the Face service", true),
                new(3, @"the Describe Image operation in the Computer Vision service"),
                new(4, @"the Analyze Image operation in the Computer Vision service"),
            }, @"You run a charity event that involves posting photos of people wearing sunglasses on Twitter.
You need to ensure that you only retweet photos that meet the following requirements:
✑ Include one or more faces.
✑ Contain at least one person wearing sunglasses.
What should you use to analyze the images?"),
            new(47, new()
            {
                new(1, @"clustering"),
                new(2, @"regression"),
                new(3, @"classification", true),
            }, @"A medical research project uses a large anonymized dataset of brain scan images that are categorized into predefined brain haemorrhage types.
You need to use machine learning to support early detection of the different brain haemorrhage types in the images before the images are reviewed by a person.
This is an example of which type of machine learning?"),
            new(48, new()
            {
                new(1, @"to train the model twice to attain better accuracy"),
                new(2, @"to train multiple models simultaneously to attain better performance"),
                new(3, @"to test the model by using data that was not used to train the model", true),
            }, @"When training a model, why should you randomly split the rows into separate subsets?"),
            new(49, new()
            {
                new(1, @"Use a graphical user interface (GUI) to run automated machine learning experiments.", true),
                new(2, @"Create a compute instance to use as a workstation."),
                new(3, @"Use a graphical user interface (GUI) to define and run machine learning experiments from Azure Machine Learning designer.", true),
                new(4, @"Create a dataset from a comma-separated value (CSV) file."),
            }, @"You are evaluating whether to use a basic workspace or an enterprise workspace in Azure Machine Learning.
What are two tasks that require an enterprise workspace? Each correct answer presents a complete solution.
NOTE: Each correct selection is worth one point.", ControlType.CheackBox),
            new(50, new()
            {
                new(1, @"Extract the invoice number from an invoice.", true),
                new(2, @"Translate a form from French to English."),
                new(3, @"Find image of product in a catalog."),
                new(4, @"Identity the retailer from a receipt.", true),
            }, @"In which two scenarios can you use the Form Recognizer service? Each correct answer presents a complete solution.
NOTE: Each correct selection is worth one point.", ControlType.CheackBox),
            new(51, new()
            {
                new(1, @"an in-car system that reads text messages aloud"),
                new(2, @"providing closed captions for recorded or live videos", true),
                new(3, @"creating an automated public address system for a train station"),
                new(4, @"creating a transcript of a telephone call or meeting", true),
            }, @"In which two scenarios can you use speech recognition? Each correct answer presents a complete solution.
NOTE: Each correct selection is worth one point.", ControlType.CheackBox),
            new(52, new()
            {
                new(1, @"Text Analytics"),
                new(2, @"Translator Text"),
                new(3, @"Speech", true),
                new(4, @"Language Understanding (LUIS)"),
            }, @"You need to build an app that will read recipe instructions aloud to support users who have reduced vision.
Which version service should you use?"),
            new(53, new()
            {
                new(1, @"Determine whether reviews entered on a website for a concert are positive or negative,
and then add a thumbs up or thumbs down emoji to the reviews."),
                new(2, @"Translate into English questions entered by customers at a kiosk so that the appropriate person can call the customers back."),
                new(3, @"Accept questions through email,
and then route the email messages to the correct person based on the content of the message."),
                new(4, @"From a website interface,
answer common questions about scheduled events and ticket purchases for a music festival.", true),
            }, @"Which scenario is an example of a webchat bot?")
        };

    }
}
