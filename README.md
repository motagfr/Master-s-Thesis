# Master Thesis: Gossiping Protocols and Information Propagation

## Overview
Hi, and welcome to the repository for my Master Thesis! This work focuses on studying the behavior of gossiping protocols in decentralized systems. I developed a Markov process to model how information spreads in such systems and verified the results through discrete-event simulation. This repository contains all the materials, applications, and research artifacts related to my thesis.

## Why This Thesis is Important
This thesis addresses a key challenge in decentralized systems: how to efficiently propagate information across a network of self-organizing nodes. In modern distributed systems, ensuring service level agreements (SLAs), managing traffic, and enabling scalability are critical. By focusing on gossiping protocols, I aimed to provide practical solutions to these challenges and offer insights into how information can spread efficiently and reliably in such systems.

This research was done in collaboration with Ericsson in Karlskrona, Sweden. Ericsson was particularly interested in optimizing decentralized systems for handling large-scale client requests.

## What Are Markov Chains?
Markov chains are a mathematical framework used to model systems that transition from one state to another based on certain probabilities. In my thesis, I used Markov chains to represent the spread of information across nodes in a network. Each state in the Markov chain corresponds to a specific number of nodes that have received the information, and the transition probabilities capture the likelihood of information spreading further. This approach allowed me to analyze the process step by step, making it a very good tool for studying gossiping protocols.

## Detailed Thesis Summary
The thesis explores the use of gossiping protocols to update the state of knowledge in a decentralized system of nodes. These protocols are particularly useful for ensuring service level agreements, handling traffic limits, and enabling scalable licensing models. Here’s what I did:

1. **Mathematical Modeling**: I introduced a Markov process to model the spread of information. This model provides a step-by-step framework to understand how information propagates in a network.

2. **Numerical Solutions**: I solved the Markov model numerically to predict the behavior of the system under various conditions.

3. **Simulation**: I conducted discrete-event simulations to validate the mathematical model. These simulations provided practical insights and verified the theoretical predictions.

4. **Analysis of Scalability**: I examined how the system scales with an increasing number of nodes. The results showed that information propagation follows a logistic curve in large systems, and scalability improves with a higher initial number of nodes.

5. **Real-World Relevance**: The findings of thesis are applicable to similar real-world decentralized systems.

### Key Insights
One of the most exciting moments for me came much later, after I had completed my thesis. I realized that the logistic curve observed in the propagation of information is also used to describe how viruses spread. This was an incredible discovery for me.

### Research Impact
Ryan Tolboom has used my work on gossip protocols for his research on simulating network growth and message passing in Secure Scuttlebutt, a peer-to-peer social network.

You can read more about how my thesis has been applied in his work [here](https://using.tech/posts/jr_2/).

### Full Text Access
The full text of my thesis, titled "An Investigation on Network Entropy-Gossiping Protocol and Anti-entropy Evaluation," is available for download on the Blekinge Institute of Technology (BTH) DiVA portal. You can access it [here](https://bth.diva-portal.org/smash/record.jsf?pid=diva2%3A829973&dswid=-277).

## Repository Structure
Here’s a quick guide to what you’ll find in this repository:

### Root Files
- **README.md**: This file, providing an overview of the thesis and repository contents.
- **Short Video Explanation.mp4**: A brief video summarizing my thesis.

### Codes and Applications
This folder contains the implementation and simulation codes for the thesis.

#### Implementation of the Mathematical Model (Desktop Application and codes)
- **Desktop Application/**: Contains the setup files for the desktop implementation of the mathematical model.
  - **setup.exe**: Installer for the application.
  - **WindowsFormsApplication1.application**: Application manifest file.
- **Visual Studio Files/**: Includes the Visual Studio solution and project files for the implementation.

#### Simulation - With Temporary Omission of Over-Picked Nodes
- **Simulation publish/**: Contains the setup file for the published version of the simulation.
  - **setup.exe**: Installer for the published application.
- **_UpgradeReport_Files/** and **Backup/**: Supporting files and logs for the simulation.
- **Visual Studio Files/**: Includes the Visual Studio solution and project files for the simulation.

#### Simulation (Desktop Application and codes)
- **Simulation Solution/** and **Visual Studio Files/**: Contain the Visual Studio solution and project files for the simulation.
- **setup.exe**: Installer for the simulation application.

### Problem Formulation
This folder contains resources related to the problem definition and initial modeling.
- **320px-Logistic-curve.svg.png**: An image of a logistic curve.
- **A model of the problem.pdf**: A detailed explanation of the problem and its mathematical model.
- **Chart1.crtx**: A chart template for visualizing data.
- **handshake.docx**: A document describing the handshake mechanism in the protocol.
- **NewRecursion.pdf**: A document explaining the recursive model used in the thesis.
- **o(k).png**: An image related to the mathematical model.
- **questions.doc**: A document listing research questions.

### RESEARCH METHODOLOGY
This folder contains research papers, presentations, and other resources I used during the thesis.
- **1-s2.0-S0743731510001711-main.pdf**: A research paper on gossiping protocols.
- **10.1.1.33.6750 (1).pdf**: A research paper on network dynamics.
- **1001.3056.pdf**: A research paper on information dissemination.
- **12-21-02.PDF**: A document related to research methodology.
- **2-gossip-globecom08.pdf**: A paper on gossip-based protocols.
- **81writing-a-paper-slides.pdf**: Slides on writing academic papers.
- **82present.pdf**: Slides on presenting research.
- **83Richard Hamming.pdf**: A document on research philosophy by Richard Hamming.
- **84stylemanual.pdf**: A style manual for academic writing.
- **dynamics of rumor spreading in complex networks.pdf**: A paper on rumor spreading dynamics.
- **Empirical Research methods in software engineering.pdf**: A guide to empirical research methods.
- **Exp_in_Context_2011.pdf**: A paper on experimental research in context.
- **icdcn09.pdf**: A paper on distributed computing networks.
- **introduction.pdf**: An introductory document on research methodology.
- **L04 Research Questions - 111111SF.pdf**: A document on formulating research questions.
- **L11 Validity Threats - 111130SF.pdf**: A document on addressing validity threats in research.
- **L11-SampleSLR.pdf**: A sample systematic literature review.
- **L11sampleCase study.pdf**: A sample case study.
- **L11sampleSurvey.pdf**: A sample survey.
- **Lavesson.PA2404.L08.Handouts.pdf**: Handouts on research methodology.
- **NLA.README.pdf**: A README document related to research.
- **p3-katoegossip.pdf**: A paper on gossiping protocols.
- **PA2404 - Industry Case Studies - 110417SF.pdf**: A document on industry case studies.
- **Projects in Computing and Information Systems - A Student’s Guide, 2nd Edition April 2009.pdf**: A guide for students working on computing projects.
- **references.pdf**: A list of references cited in the thesis.
- **Research methodology 1.pptx**: A presentation on research methodology.
- **Research methodology 2.pptx**: Another presentation on research methodology.

## How to Use This Repository
1. **Read the Thesis**: Start with the full text available on the BTH DiVA portal.
2. **Explore the Code**: Navigate to the `Codes and Applications` folder to find the implementation and simulation projects.
3. **Review the Research**: Check the `RESEARCH METHODOLOGY` folder for supporting materials and references.
4. **Understand the Problem**: Visit the `Problem Formulation` folder for detailed explanations and models.

## Contact
If you have any questions or need further information, feel free to reach out to me.

---
Thank you for your interest in my thesis!