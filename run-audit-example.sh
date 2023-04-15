#!/bin/bash

export OCI_COMPARTMENT_ID=ocid1.tenancy.oc1..aaaaaaaasehucyhfk3e4vquynnpn5aiahxynizti7asmjyggghner5dfjl3q
make build
cd Examples
dotnet run
