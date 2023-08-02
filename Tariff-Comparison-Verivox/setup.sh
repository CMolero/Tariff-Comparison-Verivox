#!/bin/bash

# Exit script on error
set -e

# Installs .NET SDK
echo "Installing .NET SDK..."
wget -q https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
sudo apt-get update
sudo apt-get install -y apt-transport-https
sudo apt-get update
sudo apt-get install -y dotnet-sdk-7.0

# Build the project
echo "Building the project..."
dotnet build
